using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Library.Repository;

namespace Library.Business
{
    public class RankBestProductStrategy:IRankStrategy<Product>
    {
        
        public Product Rank(IEnumerable<ShoppingCart> structure)
        {
            Dictionary<int, int> productDictionary = new Dictionary<int, int>();

            foreach (var cart in structure)
            {

                foreach (var item in cart.Items)
                {
                    if (!productDictionary.ContainsKey(item.ProductId))
                    {
                        productDictionary.Add(item.ProductId, item.Amount);
                    }
                    else
                    {
                        productDictionary[item.ProductId] =+ item.Amount;
                    }
                }
            }

            
            var max = productDictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            return ProductRepository.GetProductRepository().Get().First(p => p.Id == max);
        }
    }
}
