using Library.Files;
using Library.Interfaces;
using Library.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Repository
{
    public class ShoppingCartRepository : IRepository<ShoppingCart>
    {

        private readonly IFileLocator fileLocator;
        private static ShoppingCartRepository _instance;
        private static object syncRoot = new object();

        public static ShoppingCartRepository GetShoppingCartRepository()
        {
            if (_instance == null)
                lock (syncRoot)
                {
                    if (_instance == null)
                        _instance = new ShoppingCartRepository();
                }

            return _instance;
        }

        public ShoppingCartRepository()
        {
            this.fileLocator = new FileStoreJSON(
                new DirectoryInfo(@"C:\Users\MILOS\Documents\Visual Studio 2019\Projects\Library\Data"));

        }


        public IEnumerable<ShoppingCart> Get()
        {
            StreamReader reader = new StreamReader(this.fileLocator.GetFileInfo("ShoppingCarts").FullName);

            var read = reader.ReadToEnd();

            reader.Dispose();

            return ReturnFromJson<ShoppingCart>.FromJson(read);
        }

        public ShoppingCart GetById(int id)
        {

            foreach (var sc in this.Get())
            {
                if (sc.Id == id)
                    return sc;
            }

            return null;
        }


    }
}
