using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public class PersistentStore : Store
    {
        List<Product> productList = new List<Product>();
        public override void StoreProduct(Product product)
        {
            productList.Add(product);
        }
    }
}
