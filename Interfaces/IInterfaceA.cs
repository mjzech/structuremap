using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic.Interfaces
{
    public interface IInterfaceA<T>:IInterfaceB<T>, IInterfaceC<T>
    {
    }
}
