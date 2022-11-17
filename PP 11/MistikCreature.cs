using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class MistikCreature : Creature
    {
        protected string baseTalent;
        protected string ultiTalent;

        public string BaseTalent
        {
            get { return baseTalent; }
            set { baseTalent = value; }
        }        
        public string UltiTalent
        {
            get { return ultiTalent; }
            set { ultiTalent = value; }
        }
        public MistikCreature(string name, int age, int healPts, int damage, int luck,string baseTalent, string ultiTalent)
        {
            this.name = name;this.age = age;this.healPts = healPts;this.damage = damage;this.luck = luck;

            this.baseTalent = baseTalent;
            this.ultiTalent = ultiTalent;
        }
        public MistikCreature(){}

        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Мистическое существо\nИмя = {name}\nВозраст = {age}" +
                $"\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}" +
                $"\nБазовый талант = {baseTalent}\nУльтимативный талант = {ultiTalent}");
        }
        public virtual MistikCreature Create()
        {
            Random rand = new Random();
            MistikCreature nothing = new MistikCreature("nothing", rand.Next(1,99), 
                rand.Next(1,10000), rand.Next(1,999), rand.Next(1,10), "-", "-");
            return nothing;
        }
    }
}
