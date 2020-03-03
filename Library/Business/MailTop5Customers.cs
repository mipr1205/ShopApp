using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business
{
    public class MailTop5Customers : IMailingStrategy<Customer>
    {
        private ISortCartStrategy _sortedIds;

        public MailTop5Customers(ISortCartStrategy sorted)
        {
            this._sortedIds = sorted;
        }
        public void Mailing(IEnumerable<Customer> sortedList)
        {
            
        }
    }
}
