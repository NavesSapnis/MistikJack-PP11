using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class Goblin : MistikCreature
    {
        //Goblin damage = damage *0/1/2/3/4/5...
        private int damageMultip;
        
        public int DamageMultip
        {
            get { return damageMultip; }
            set 
            {
                if (value < 0)
                {
                    damageMultip = 1;
                }
                else
                {
                    damageMultip = value;
                }
            }
        }

        public Goblin(string name, int age, int healPts, int damage, int luck, string baseTalent, string ultiTalent,int damageMultip):base(name, age, healPts, damage, luck, baseTalent, ultiTalent)
        {
            this.damageMultip = damageMultip;
            this.damage = damage * damageMultip;
        }

        public Goblin() {}
        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Гоблин\nИмя = {name}\nВозраст = {age}\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}\nБазовый талант = {baseTalent}\nУльтимативный талант = {ultiTalent}");
        }
        public override MistikCreature Create()
        {
            Random rand = new Random();
            string[] baseDiscription = {"Имеет скрытую способность к воровству","Легко залечивает раны","Имеет вероятность избежать драки" };
            string[] ultiDiscription = { "Умирая, отравляет область около себя", "Можно нанять за определенную плату", "Имеет склонность к обману" };
            Goblin goblin = new Goblin("base goblin", rand.Next(1, 99), rand.Next(1, 10000), rand.Next(1, 999), rand.Next(1, 10), baseDiscription[rand.Next(0,2)], ultiDiscription[rand.Next(0,2)], rand.Next(1, 5));
            return goblin;
        }
    }
}
