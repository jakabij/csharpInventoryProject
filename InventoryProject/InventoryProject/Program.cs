using System;

namespace InventoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreManager manager = new StoreManager();
            StorageCapable capable=null;
            manager.AddStorage(capable);
            manager.AddCDProduct("ASD", 2, 10);
        }
    }
}
