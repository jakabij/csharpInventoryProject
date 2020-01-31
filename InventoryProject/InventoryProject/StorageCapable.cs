using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public interface StorageCapable
    {
        List<Product> GetAllProduct();
        void StoreCdProduct(CDProduct product);
        void StoreBookProduct(BookProduct product);
    }
}
