using Library.Files;
using Library.Interfaces;
using Library.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly IFileLocator fileLocator;
        private static ProductRepository _instance;
        private static object syncRoot = new object();

        public static ProductRepository GetProductRepository()
        {
            if (_instance == null)
                lock (syncRoot)
                {
                    if (_instance == null)
                        _instance = new ProductRepository();
                }

            return _instance;
        }

        public ProductRepository()
        {
            this.fileLocator = new FileStoreJSON(
                new DirectoryInfo(@"C:\Users\MILOS\Documents\Visual Studio 2019\Projects\Library\Data"));

        }

        public IEnumerable<Product> Get()
        {
            StreamReader reader = new StreamReader(this.fileLocator.GetFileInfo("Products").FullName);

            var read = reader.ReadToEnd();

            reader.Dispose();

            return ReturnFromJson<Product>.FromJson(read);
        }

        public Product GetById(int id)
        {

            foreach (var p in this.Get())
            {
                if (p.Id == id)
                    return p;
            }

            return null;
        }
    }
}
