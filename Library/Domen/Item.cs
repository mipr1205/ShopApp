using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Item:IEntity
    {
        public int Id { get; set; }

        public int ShoppingCartId { get; set; }

        public int ProductId { get; set; }

        public int  Amount { get; set; }

        public Product Product { get; set; }


        public override string ToString()
        {
            return $"{Product} - Amount: {Amount}";
        }


    }
}
