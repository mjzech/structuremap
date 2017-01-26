using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic.Interfaces
{
    public interface IInterfaceB<T>
    {
        IEnumerable<T> ExecBase_SP(string x, DateTime? startDate, DateTime? endDate, int? xType);
    }
}
