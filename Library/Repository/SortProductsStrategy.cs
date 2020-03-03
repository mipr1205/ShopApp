using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Library.Repository
{
    public class SortProductsStrategy : ISortCartStrategy

    {
        public IEnumerable<int> SortCart(IEnumerable<ShoppingCart> carts)
        {
            Dictionary<int, int> productDictionary = new Dictionary<int, int>();

            foreach (var cart in carts)
            {

                foreach (var item in cart.Items)
                {
                    if (!productDictionary.ContainsKey(item.ProductId))
                    {
                        productDictionary.Add(item.ProductId, item.Amount);
                    }
                    else
                    {
                        productDictionary[item.ProductId] = +item.Amount;
                    }
                }
            }

            var sortedDict = from entry in productDictionary orderby entry.Value ascending select entry;

            List<int> keyList = ((Dictionary<int, int>)sortedDict).Keys.ToList();

            return keyList;



        }
    }
}
