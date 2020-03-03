using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Library.Interfaces
{
    interface IRepository<T> where T:IEntity 
    {
       

        IEnumerable<T> Get();

        T GetById(int id);





    }
}
