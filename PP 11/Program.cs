using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace PP_11
{
    internal class Program
    {
        public static int Menu()
        {
            Console.WriteLine("Выберите пункт меню\n1 - выбрать Персонажа");
            int ret = Convert.ToInt32(Console.ReadLine());
            return ret;
        }

        public static void Discription(string type)
        {
            Console.WriteLine($"Вы выбрали {type}," +
                $" чтобы спасти принцесу вам придется победить какое-то мистическое существо\nИдя по болоту вы натыкакетесь на... ");
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            MistikCreature[] mistikCreatures= new MistikCreature[3];
            mistikCreatures[0] = new Dragon("Крассный рогнарос", 341, 8800, 666, 1, "С высокой вероятностью убежит, если ему нанести" +
                " более 2.000 ед. урона", "Уменьшение урона каждый ход на 22 ед.", "Красный - огненный", 100);
            mistikCreatures[1] = new Goblin().Create();
            mistikCreatures[2] = new Troll().Create();
            MistikCreature enemy = mistikCreatures[rand.Next(0, 2)];
            while (true)
            {
                try
                {
                    switch (Menu())
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("1-Рыцарь\n2-Лучник\n3-Фермер");
                            int choise = Convert.ToInt32(Console.ReadLine());
                            switch (choise)
                            {
                                case 1:
                                    Knight knight = new Knight();
                                    Discription("Рыцарь");
                                    
                                    break;
                                case 2:
                                    BowFighter bowFighter = new BowFighter();
                                    Discription("Лучник");
                                    //enemy.PrintInfo();
                                    break;
                                case 3:
                                    HumanWithSpear farmer = new HumanWithSpear();
                                    Discription("Крестьянин к копьем");
                                    //enemy.PrintInfo();
                                    break;
                            }
                            enemy.PrintInfo();
                            break;
                        case 2:

                            break;
                        case 3:
                            Console.Clear();

                            break;
                        case 4:
                            Console.Clear();

                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                }
            }
            //Human human = new Human("Jack", 33, 670, 14.44, 7, "Kai", 3);
            //human.PrintInfo();
            //MistikCreature mistikCreature = new MistikCreature();
            //Console.WriteLine("");
            //mistikCreature.PrintInfo();
            //Knight knight = new Knight();
            //knight.PrintInfo();
            //Goblin goblin = new Goblin("Goblin 1", 22, 600, 120, 3, "Ходит на 1 ноге", "Может убежать с поля битвы", 2);
            //Knight knight = new Knight("Олег", 21, 1000, 200, 2, "Крутой", 333, 120, "Деревянный меч", 200);
            //Console.WriteLine("\n\n\n\n");
            //goblin.Attack(knight);
            


        }
    }
}
