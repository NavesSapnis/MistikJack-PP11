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
                "\n3 - В БОЙ!\n4 - Зайти в магазин\n5 - Вывести массив уродцев\n6 - Найти максимальный/минимальный по урону\n7 - Отсортировать по имени");
            int ret = Convert.ToInt32(Console.ReadLine());
            return ret;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            MistikCreature[] enemies = new MistikCreature[3];
            enemies[0] = new Dragon("Крассный рогнарос", 341, 8800, 666, 1, 
                "С высокой вероятностью убежит, если ему нанести более 2.000 ед. урона", 
                "Уменьшение урона каждый ход на 22 ед.", "Красный - огненный", 100); 
            enemies[1] = new Goblin().Create(); enemies[2] = new Troll().Create();
            MistikCreature enemy = enemies[rand.Next(0, 3)];

            Human[] heroes = new Human[3];
            Human hero = new Human();

            ShopItems shopItems = new ShopItems();
            shopItems = shopItems.CreateShop();

            AllClass allClass = new AllClass(enemies);
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
                                    hero = bowFighter.Create();
                                    break;
                                case 3:
                                    HumanWithSpear farmer = new HumanWithSpear();
                                    hero = farmer.Create();
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            hero.PrintInfo();
                            break;
                        case 3:
                            Console.Clear();
                            while (true)
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
                                    if (enemy.HealPts <= 0)
                                    {
                                        Console.WriteLine("Победа!!!");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        break;
                                    }
                                    else if(hero.HealPts <= 0)
                                    {
                                        Console.WriteLine("К сожалениею в этот раз вам не удалось спасти принцесу");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        break;
                                    }
                                    
                                    hero.Attack(enemy);
                                    System.Threading.Thread.Sleep(1000);

                                    Console.Clear();
                                    enemy.Attack(hero);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
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
                        case 5:
                            
                            break;
                        case 6:
                            
                            Console.WriteLine(allClass.MinDamage());
                            break;
                        case 7:
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
