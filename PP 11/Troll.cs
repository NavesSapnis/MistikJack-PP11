using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{//хуй
    internal class Troll : MistikCreature
    {
        //can fight with human if human luck more than 7...
        private int armor;

        public int Armor
        {
            get { return armor; }
            set 
            {
                if (value < 0)
                {
                    armor = 1;
                }
                else
                {
                    armor = value;
                }
            }
        }
        
        public Troll(string name, int age, int healPts, int damage, int luck, 
            string baseTalent, string ultiTalent, int armor) : base(name, age, healPts, damage, luck, baseTalent, ultiTalent)
        {
            this.healPts =healPts+ armor;
        }

        public Troll() {}
        public Troll(string name)
        {
            this.name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Троль\nИмя = {name}\nВозраст = {age}" +
                $"\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}" +
                $"\nБазовый талант = {baseTalent}\nУльтимативный талант = {ultiTalent}");
        }

        public override MistikCreature Create()
        {
            Random rand = new Random();
            string[] baseDiscription = { 
                "Имеет скрытую способность к воровству", 
                "Легко залечивает раны", 
                "Имеет вероятность избежать драки" };
            string[] ultiDiscription = { 
                "Умирая, отравляет область около себя",
                "Можно нанять за определенную плату", 
                "Имеет склонность к обману" };
            Troll troll = new Troll("base troll", rand.Next(10, 99), rand.Next(1000, 10000), rand.Next(200, 500), 
                rand.Next(1, 2), baseDiscription[rand.Next(0, 3)], ultiDiscription[rand.Next(0, 3)], rand.Next(1, 10000));
            return troll;
        }
    }
}
