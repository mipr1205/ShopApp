using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    class MailTop10Customers : IMailingStrategy<Customer>
    {
        public void Mailing(IEnumerable<Customer> sortedList)
        {
            throw new NotImplementedException();
        }
    }
}
