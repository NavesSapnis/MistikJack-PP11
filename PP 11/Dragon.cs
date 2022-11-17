﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class Dragon : MistikCreature
    {
        private string dragonType;
        private int bonusDamage;

        public string DragonType
        {
            get { return dragonType; }
            set { dragonType = value; }
        }
        public int BonusDamage
        {
            get { return bonusDamage; }
            set { bonusDamage = value; }
        }

        public Dragon(string name, int age, int healPts, int damage, int luck, string baseTalent, string ultiTalent,
            string dragonType, int bonusDamage) : base(name, age, healPts, damage, luck, baseTalent, ultiTalent)
        {
            this.dragonType = dragonType;
            this.damage = damage + bonusDamage;
        }
        public Dragon() { }
        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Дракон\nИмя = {name}\nВозраст = {age}" +
                $"\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}" +
                $"\nБазовый талант = {baseTalent}\nУльтимативный талант = {ultiTalent}\nТип дракона = {dragonType}");
        }
        public override MistikCreature Create()
        {
            string[] baseDiscription = {
                "Имеет скрытую способность к воровству",
                "Легко залечивает раны",
                "Имеет вероятность избежать драки" };
            string[] ultiDiscription = {
                "Умирая, отравляет область около себя",
                "Можно нанять за определенную плату",
                "Имеет склонность к обману" };
            Random rand = new Random();
            Dragon dragon = new Dragon("base dragon", rand.Next(50, 99), rand.Next(5000, 10000),
                rand.Next(1000, 6000), rand.Next(1, 5), baseDiscription[rand.Next(0,3)], ultiDiscription[rand.Next(0, 3)], "Зеленый", rand.Next(-1000, 2000));
            return dragon;
        }
    }
}
