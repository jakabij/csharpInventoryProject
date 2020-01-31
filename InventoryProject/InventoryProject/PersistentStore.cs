using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public class PersistentStore : Store
    {
        public override void StoreProduct(Product product)
        {
            products.Add(product);
        }
    }
}
