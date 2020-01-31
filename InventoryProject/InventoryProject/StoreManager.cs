using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace InventoryProject
{
    public class StoreManager : StorageCapable
    {
        CDProduct cdProduct;
        BookProduct bookProduct;

        List<CDProduct> cdProducts = new List<CDProduct>();
        List<BookProduct> bookProducts = new List<BookProduct>();

        public void AddStorage(StorageCapable storage)
        {
            Console.WriteLine("Add a CD product!\nFirst it's Name:");
            string name=Console.ReadLine();

            Console.WriteLine("The price:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("The tracks:");
            int tracks = int.Parse(Console.ReadLine());

            AddCDProduct(name,price,tracks);
            storage.StoreCdProduct(this.cdProduct);



            Console.WriteLine("Add a book product!\nFirst it's Name:");
            name = Console.ReadLine();

            Console.WriteLine("The price:");
            price = int.Parse(Console.ReadLine());

            Console.WriteLine("The tracks:");
            int pages = int.Parse(Console.ReadLine());

            AddBookProduct(name, price, pages);
            storage.StoreBookProduct(this.bookProduct);
        }

        public void AddCDProduct(string name,int price,int tracks)
        {
            this.cdProduct.Name = name;
            this.cdProduct.Price = price;
            this.cdProduct.NumOfTracks = tracks;
        }

        public void AddBookProduct(string name, int price, int pages)
        {
            this.bookProduct.Name = name;
            this.bookProduct.Price = price;
            this.bookProduct.NumOfPages = pages;
        }

        public void StoreCdProduct(CDProduct product)
        {
            this.cdProducts.Add(product);
        }

        public void StoreBookProduct(BookProduct product)
        {
            this.bookProducts.Add(product);
        }

        public string ListProducts()
        {
            string result = "";
            for(int count=0;count<this.bookProducts.Count;count++)
            {
                result += this.bookProducts[count].Name;
                result += ", ";
            }
            
            for (int count = 0; count < this.cdProducts.Count; count++)
            {
                result += this.cdProducts[count].Name;
                result += ", ";
            }
            return result;
        }

        public int GetTotalProductPrice()
        {
            int sum=0;
            for (int count = 0; count < this.bookProducts.Count; count++)
            {
                sum += this.bookProducts[count].Price;
            }

            for (int count = 0; count < this.cdProducts.Count; count++)
            {
                sum += this.cdProducts[count].Price;
            }

            return sum;
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

       
    }
}
