using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    interface IMailingStrategy<T>
    {
        void Mailing(IEnumerable<T> sortedList);   
    }
}
