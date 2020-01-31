using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public class BookProduct :Product
    {
        public int NumOfPages { get; set; } 

        public BookProduct(string name,int price,int pages)
        {
            this.Name = name;
            this.Price = price;
            this.NumOfPages = pages;
        }
    }
}
