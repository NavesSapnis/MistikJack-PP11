using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    abstract class Creature
    {
        protected string name;
        protected int age;
        protected int healPts;
        protected int damage;
        protected int luck;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return Age; }
            set
            {
                if (value < 0 || value > 99)
                {
                    Age = 1;
                }
                else
                {
                    Age = value;
                }
            }
        }
        public int HealPts
        {
            get { return healPts; }
            set
            {
                if (value > 100000)
                {
                    Console.WriteLine("У вас слишком много хп, для баланса мы их уменьшим xd");
                    HealPts = 1000;
                }
                else
                {
                    healPts = value;
                }
            }
        }
        public int Damage
        {
            get { return damage; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    Console.WriteLine("У вас слишком много урона, для баланса мыуменьшим xd");
                    damage = 100;
                }
                else
                {
                    damage = value;
                }
            }
        }
        public int Luck//Luck will work as charisma+luck
        {
            get { return luck; }
            set
            {
                if (value > 10)
                {
                    luck = 1;
                }
                else
                {
                    luck = value;
                }
            }
        }
        public abstract void PrintInfo();
        public void Attack(Creature someOne)
        {
            Console.WriteLine($"Здоровье цели до удара = {someOne.HealPts} ");
            someOne.HealPts -= this.Damage;
            Console.WriteLine($"Здоровье цели после удара = {someOne.HealPts} ");
        }

    }
}
