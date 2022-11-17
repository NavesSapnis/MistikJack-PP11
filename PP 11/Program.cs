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
            Console.WriteLine("Выберите пункт меню\n1 - Выбрать Персонажа\n2 - Вывести характеристики персонажа" +
                "\n3 - В БОЙ!\n4 - Зайти в магазин");
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

            MistikCreature[] enemies = new MistikCreature[3];
            enemies[0] = new Dragon("Крассный рогнарос", 341, 8800, 666, 1, "С высокой вероятностью убежит, если ему нанести более 2.000 ед. урона", "Уменьшение урона каждый ход на 22 ед.", "Красный - огненный", 100); enemies[1] = new Goblin().Create(); enemies[2] = new Troll().Create();
            MistikCreature enemy = enemies[rand.Next(0, 3)];

            Human[] heroes = new Human[3];
            Human hero = new Human();
            ShopItems shopItems = new ShopItems();
            shopItems = shopItems.CreateShop();

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
                                    hero = knight.Create();
                                    break;
                                case 2:
                                    BowFighter bowFighter = new BowFighter();
                                    Discription("Лучник");
                                    hero = bowFighter.Create();
                                    break;
                                case 3:
                                    HumanWithSpear farmer = new HumanWithSpear();
                                    Discription("Крестьянин к копьем");
                                    hero = farmer.Create();
                                    break;
                            }
                            //enemy.PrintInfo();
                            break;
                        case 2:
                            Console.Clear();
                            hero.PrintInfo();
                            break;
                        case 3:
                            Console.Clear();
                            while (hero.HealPts >= 0 || enemy.HealPts >= 0)
                            {
                                enemy.PrintInfo();
                                var trollCheck = enemy.GetType();
                                if (trollCheck == typeof(Troll) && hero.Luck >= 7)
                                {
                                    Console.WriteLine("\n\nВы слишком удачливы, противник перешен на вашу сторону. Победа !!!\n\nS");
                                    break;
                                }
                                else
                                {
                                    hero.Attack(enemy);
                                    Console.WriteLine("...");
                                    System.Threading.Thread.Sleep(50000);
                                }
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("");
                            
                            shopItems.PrintShop();
                            Console.WriteLine("Что желаете купить ?");
                            choise = Convert.ToInt32(Console.ReadLine());
                            switch (choise)
                            {
                                case 1:
                                    hero.Buy(shopItems.items[0]);
                                    Console.Clear();
                                    break;
                                case 2:
                                    hero.Buy(shopItems.items[1]);
                                    Console.Clear();
                                    break;
                                case 3:
                                    hero.Buy(shopItems.items[2]);
                                    Console.Clear();
                                    break;
                                case 4:
                                    hero.Buy(shopItems.items[3]);
                                    Console.Clear();
                                    break;
                                case 5:
                                    hero.Buy(shopItems.items[4]);
                                    Console.Clear();
                                    break;
                                case 6:
                                    hero.Buy(shopItems.items[5]);
                                    Console.Clear();
                                    break;
                                case 7:
                                    hero.Buy(shopItems.items[6]);
                                    Console.Clear();
                                    break;
                                case 8:
                                    hero.Buy(shopItems.items[7]);
                                    Console.Clear();
                                    break;
                                case 9:
                                    hero.Buy(shopItems.items[8]);
                                    Console.Clear();
                                    break;
                                case 10:
                                    hero.Buy(shopItems.items[9]);
                                    Console.Clear();
                                    break;
                                default:
                                    break;
                            }
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
        }
    }
}
