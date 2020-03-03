using Library.Interfaces;
using System;

namespace Library
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
