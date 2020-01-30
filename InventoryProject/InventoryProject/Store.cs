using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace InventoryProject
{
    public abstract class Store : StorageCapable
    {
        public void SaveToXml(Product product)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Product));
            using (StreamWriter writer = new StreamWriter("products.xml"))
            {
                xml.Serialize(writer, product);
            }
        }


        public abstract void StoreProduct(Product product);

        public Product CreateProduct(string type,string name,int price,int size)
        {
            return null;
        }

        public List<Product> LoadProducts()
        {
            return null;
        }

        public void store(Product product)
        {
            //SaveToXml();
            //StoreProduct();
        }









        public List<Product> GetAllProduct()
        {
            throw new NotImplementedException();
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
