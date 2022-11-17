﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class BowFighter : Human
    {
        private string bowType;
        private int damageByBow;

        public string BowType
        {
            get { return bowType; }
            set { bowType = value; }
        }
        public int DamageByBow
        {
            get { return damageByBow; }
            set 
            {
                if (value < 0)
                {
                    damageByBow = 1;
                }
                else
                {
                    damageByBow = value;
                }
            }
        }
        public BowFighter(string name, int age, int healPts, int damage, int luck, string secondName,
            int money, string bowType, int damageByBow) : base(name, age, healPts, damage, luck, secondName, money)
        {
            this.bowType = bowType;
            this.damage = damage + damageByBow;
        }
        public BowFighter() { }
        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Лучник\nИмя = {name}\nФамилия = {secondName}\nВозраст = {age}" +
                $"\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}\nДеньги = {money} $\nТип оружия = {bowType}");
        }
        public override Human Create()
        {
            Random rand = new Random();
            BowFighter bowFighter = new BowFighter("Jack", rand.Next(1, 99), rand.Next(1, 10000), rand.Next(1, 999),
                rand.Next(1, 10), "Jackson", 100, "Деревянный лук", rand.Next(1, 1000));
            return bowFighter;
        }
    }
}
