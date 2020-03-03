using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    interface IRankStrategy<T>
    {
        T Rank(IEnumerable<ShoppingCart> structure);
    }
}
