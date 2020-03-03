using Library.Files;
using Library.Interfaces;
using Library.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly IFileLocator fileLocator;
        private static CustomerRepository _instance;
        private static object syncRoot = new object();
       

        public static CustomerRepository GetCustomerRepository()
        {
            if (_instance == null)
                lock (syncRoot)
                {
                    if (_instance == null)
                        _instance = new CustomerRepository();
                }

            return _instance;
        }

        private CustomerRepository()
        {
            this.fileLocator = new FileStoreJSON(
                new DirectoryInfo(@"C:\Users\MILOS\Documents\Visual Studio 2019\Projects\Library\Data"));

        }

        public IEnumerable<Customer> Get()
        {
           StreamReader reader = new StreamReader(this.fileLocator.GetFileInfo("Customers").FullName);

            var read = reader.ReadToEnd();

            reader.Dispose();

            return ReturnFromJson<Customer>.FromJson(read);

        }

        public Customer GetById(int id)
        {
   
            foreach (var c in this.Get() )
            {
                if (c.Id == id)
                    return c;
            }

            return null;
        }


    }
}
