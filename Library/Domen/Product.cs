using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
   public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
