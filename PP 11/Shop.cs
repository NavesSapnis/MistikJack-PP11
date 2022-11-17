using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    class Shop
    {
        private int price;
        private int damage;
        private int armor;
        private string discription;

        public int Price
        {
            get { return price; }
            set { value = price; }
        }
        public int Damage
        {
            get { return damage; }
            set { value = damage; }
        }

        public int Armor
        {
            get { return armor; }
            set { value = armor; }
        }
        public string Discription
        {
            get { return discription; }
            set { value = discription; }
        }

        public Shop(int price,int damage,int armor,string discription)
        {
            this.price = price;
            this.damage = damage;
            this.armor = armor;
            this.discription = discription;
        }
        public Shop() {}
    

    }
}
