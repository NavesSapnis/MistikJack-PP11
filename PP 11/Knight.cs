using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class Knight : Human
    {
        private int swordDamage;
        private string swordType;
        private int lightArmor;

        public int SwordDamage
        {
            get { return swordDamage; }
            set 
            {
                swordDamage = value; //any value
            }
        }
        public string SwordType
        {
            get { return swordType; }
            set { swordType = value; }
        }
        public int LightArmor
        {
            get { return lightArmor; }
            set 
            { 
                if(value < 0)
                {
                    lightArmor = 1;
                }
                else 
                {
                    lightArmor = value;
                }

            }
        }
        public Knight(string name, int age, int healPts, int damage, int luck, string secondName,
            int money, int swordDamage, string swordType, int lightArmor) : base(name, age, healPts, damage, luck, secondName, money)
        {
            this.damage = damage + swordDamage;
            this.swordType = swordType;
            this.healPts = healPts + lightArmor;
        }
        public Knight() { }

        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Рыцарь\nИмя = {name}\nФамилия = {secondName}\nВозраст = {age}" +
                $"\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}\nДеньги = {money} $");
        }
        public override Human Create()
        {
            Random rand = new Random();
            Knight knight = new Knight("Jack", rand.Next(1, 99), rand.Next(1, 10000), rand.Next(1, 999),
                rand.Next(1, 10), "Jackson", 100,rand.Next(1,1000), "Деревянный меч", rand.Next(1, 1000));
            return knight;

        }
    }
}
