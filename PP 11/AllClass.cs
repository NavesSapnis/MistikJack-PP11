using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class AllClass
    {
        private Creature[] somethings;

        public AllClass(Creature[] somethings)
        {
            this.somethings = somethings;
        }
        public AllClass() { }

        public Creature MaxDamage()
        {
            int max = somethings[0].Damage;
            for (int i = 0; i < somethings.Length; i++)
            {
                if (somethings[i].Damage > max)
                {
                    max = somethings[i].Damage;
                }
            }
            for (int i = 0; i < somethings.Length; i++)
            {
                if (somethings[i].Damage==max)
                    return somethings[i];
            }
            return somethings[0];
        }
        public Creature MinDamage()
        {
            int min = somethings[0].Damage;
            for (int i = 0; i < somethings.Length; i++)
            {
                if (somethings[i].Damage < min)
                {
                    min = somethings[i].Damage;
                }
            }
            for (int i = 0; i < somethings.Length; i++)
            {
                if (somethings[i].Damage == min)
                    return somethings[i];
            }
            return somethings[0];
        }
        public void PrintAll()
        {
            for (int i = 0; i < somethings.Length; i++)
            {
                Console.WriteLine(somethings[i]);
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            }
        }
        public AllClass CreateArr()
        {
            Creature[] arr = new Creature[6];
            arr[0] = new Knight().Create(); arr[0].Name = "Jame";
            arr[1] = new BowFighter().Create(); arr[1].Name = "Jame W Bow";
            arr[2] = new HumanWithSpear().Create(); arr[2].Name = "Just a farmer";
            arr[3] = new Dragon().Create(); arr[3].Name = "Blood dragon";
            arr[4] = new Goblin().Create(); arr[4].Name = "Greedy Jack";
            arr[5] = new Troll().Create(); arr[5].Name = "Bastrard Troll";///8.45

            AllClass ArrOfIdiots = new AllClass(arr);
            return ArrOfIdiots;
        }
        public AllClass SortByName()
        {
            Creature temp;
            for (int i = 0; i < somethings.Length; i++)
            {
                for (int j = 0; j < somethings.Length - 1; j++)
                {
                    if (somethings[j].Name.Length > somethings[j + 1].Name.Length)
                    {
                        temp = somethings[j + 1];
                        somethings[j + 1] = somethings[j];
                        somethings[j] = temp;
                    }
                }
            }
            AllClass sortedCreatures = new AllClass();
            return sortedCreatures;
        }
    }
}
