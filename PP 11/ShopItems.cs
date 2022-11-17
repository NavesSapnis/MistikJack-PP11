using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    class ShopItems
    {
        public Shop[] items;

        public ShopItems(Shop[] items)
        {
            this.items = items;
        }
        public ShopItems(){}

        public ShopItems CreateShop()
        {
            Random random = new Random();
            Shop[] shop = new Shop[10];

            for (int i = 0; i < shop.Length; i++)
            {
                shop[i] = new Shop(random.Next(1, 100), random.Next(100, 1000), random.Next(100, 1000), "Маленькая инди-студия не прописала описание");
            }
            ShopItems shopItems = new ShopItems(shop);
            return shopItems;
        }
        public void PrintShop()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
