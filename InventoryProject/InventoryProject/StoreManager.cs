using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace InventoryProject
{
    public class StoreManager : StorageCapable
    {
        public void AddStorage(StorageCapable storage)
        {

        }

        public void AddCDProduct(string name,int price,int tracks)
        {

        }

        public void AddBookProduct(string name, int price, int pages)
        {

        }

        public string ListProducts()
        {
            return null;
        }

        public int GetTotalProductPrice()
        {
            return 0;
        }









        public List<Product> GetAllProduct()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            List<Product> allProduct = new List<Product>();
            using (FileStream reader = File.OpenRead("products.xml"))
            {
                allProduct=(List<Product>)xml.Deserialize(reader);
            }

            return allProduct;
        }

        public void StoreCdProduct(string name, int price, int tracks)
        {
            throw new NotImplementedException();
        }

        public void StoreBookProduct(string name, int price, int pages)
        {
            throw new NotImplementedException();
        }
    }
}
