using System;
using System.Collections.Generic;

namespace generic.Interfaces
{
    public interface IInterfaceC<T>
    {
        IEnumerable<T> ExecEx_SP(string x, DateTime? startDate, DateTime? endDate, int? xType, int? dx, decimal? xlevel1, decimal? xLevel2);
    }
}
