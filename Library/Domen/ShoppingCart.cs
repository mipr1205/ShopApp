using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
   public class ShoppingCart:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public IEnumerable<Item> Items { get; set; }



    }
}
