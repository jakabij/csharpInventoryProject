using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public class CDProduct:Product
    {
       public int NumOfTracks { get; set; }

        public CDProduct(string name,int price,int tracks)
        {
            this.Name = name;
            this.Price = price;
            this.NumOfTracks = tracks;
        }
    }
}
