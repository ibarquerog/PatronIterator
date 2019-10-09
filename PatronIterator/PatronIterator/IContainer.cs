using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    interface IContainer<T>
    {
        IIterator<T> createIterator();
    }
}
