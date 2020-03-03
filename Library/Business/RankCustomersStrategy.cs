using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Business
{
    public class RankCustomersStrategy : IRankStrategy<Customer>
    {
        public Customer Rank(IEnumerable<ShoppingCart> structure)
        {
            Dictionary<int, double> customerDictionary = new Dictionary<int, double>();

            foreach (var cart in structure)
            {
                double moneySpent = 0;

                foreach (var item in cart.Items)
                {
                    moneySpent += item.Product.Price * item.Amount;
                }

                if (!customerDictionary.ContainsKey(cart.CustomerId))
                {
                    customerDictionary.Add(cart.CustomerId, moneySpent);
                }
                else
                {
                    customerDictionary[cart.CustomerId] = +moneySpent;
                }
                
            }

            var max = customerDictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;


            return CustomerRepository.GetCustomerRepository().Get().First(c => c.Id == max);
            


            //var sortedDict = from entry in customerDictionary orderby entry.Value ascending select entry;

            //int first = sortedDict.FirstOrDefault(e => e.Key);

        }
    }
}
