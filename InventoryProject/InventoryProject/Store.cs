using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace InventoryProject
{
    public abstract class Store : StorageCapable
    {
        public List<Product> products=new List<Product>();


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
            Product product;
            if(type.ToLower().Equals("cd"))
            {
                product = new CDProduct(name, price, size);
            }
            else if(type.ToLower().Equals("book"))
            {
                product = new BookProduct(name, price, size);
            }
            else
            {
                throw new Exception("No type like that!");
            }

            return product;
        }




        public List<Product> LoadProducts()         //////////////////////////////////////////
        {
            return products;
        }








        public void ToStore(Product product)
        {
            SaveToXml(product);
            StoreProduct(product);
        }

        public List<Product> GetAllProduct()
        {
            return products;
        }

        public void StoreBookProduct(string name, int price, int pages)
        {
            Product resultProduct = CreateProduct("Book", name, price, pages);
            ToStore(resultProduct);
        }

        public void StoreCdProduct(string name, int price, int tracks)
        {
            Product resultProduct = CreateProduct("CD", name, price, tracks);
            ToStore(resultProduct);
        }



    }
}
