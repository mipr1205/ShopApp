using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface ISortCartStrategy
    {
        IEnumerable<int> SortCart(IEnumerable<ShoppingCart> carts);
    }
}
