using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class Human : Creature
    {

        protected string secondName;
        protected int money;



        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public int Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    this.healPts = 1;
                }
                else
                {
                    money = value;
                }
            }
        }
        public Human(string name, int age, int healPts, int damage, int luck, string secondName, int money)
        {
            this.name = name; this.age = age; this.healPts = healPts; this.damage = damage;this.luck = luck;

            this.secondName = secondName;
            this.money = money;
        }
        public Human() { }

        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Человек\nИмя = {name}\nФамилия = {secondName}\nВозраст = {age}" +
                $"\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}\nДеньги = {money} $");
        }
        public virtual Human Create()
        {
            Random rand = new Random();
            Human nothing = new Human("nothing", rand.Next(1, 99), rand.Next(1, 10000), rand.Next(1, 999), rand.Next(1, 10), "nothing", 100);
            return nothing;
        }
        public virtual void Buy(Shop someThing)
        {
            if (this.Money < someThing.Price)
            {
                Console.WriteLine("У вас недостаточно денег");
            }
            else
            {
                this.Money-=someThing.Price;
                this.Damage+=someThing.Damage;
            }
        }
        

    }
}
