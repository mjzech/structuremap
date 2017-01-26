using System;
using System.Collections.Generic;
using System.Linq;
using generic.Interfaces;

namespace generic.Repositories
{
    public class StatRepo<T> where T : IInterfaceA<T>
    {
        #region private variables
        private readonly statEntities _statContext;
        #endregion
        #region inject context
        public StatRepo(statEntities statContext)  //DI for the context
        {
            _statContext = statContext;
        }
        #endregion
        #region ExecBasic
        public IEnumerable<Select_Result> ExecBase_SP(DateTime startDate, DateTime endDate,
                 string x, int? xType)
        {
            try
            {
                return
                    _statContext.Base_Select(startDate, endDate, x, xType)
                        .AsEnumerable();
            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally
            {
                _statContext.Dispose();
            }
        }
        #endregion
        #region ExecExtended
        public IEnumerable<Select_Result> ExecStatisticsExtended_SP(string x, DateTime? startDate, DateTime? endDate, int? xType, int? dx, decimal? xLevel1, decimal? xLevel2)
        {
            try
            {
                return
                    _statContext._Select(startDate, endDate, x,dx,xType,xLevel1, xLevel2)
                        .AsEnumerable();
            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally
            {
                _statContext.Dispose();
            }
        }
        #endregion
    }
}