using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    class ShopItems
    {
        Shop[] items = new Shop[10];

        public ShopItems(Shop[] items)
        {
            this.items = items;
        }
        public ShopItems(){}

        public ShopItems CreateShop()
        {
            Random random = new Random();
            for (int i = 0; i < items.Length; i++)
            {
                items[i].Armor = random.Next(100, 1000);
                items[i].Damage = random.Next(100, 1000);
                items[i].Price = random.Next(1, 100);
                items[i].Discription = "Маленькая инди-студия не прописала описание";
            }
            return items;
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
