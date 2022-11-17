﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_11
{
    internal class HumanWithSpear : Human
    {
        //Farmer with a spear :3
        private int damageBySpear;

        public int DamageBySpear
        {
            get { return damageBySpear; }
            set { damageBySpear = value; }//any value
        }
        public HumanWithSpear(string name, int age, int healPts, int damage, int luck, string secondName, int money, int damageBySpear) : base(name, age, healPts, damage, luck, secondName, money)
        {
            this.damage = damage + damageBySpear;
        }
        public HumanWithSpear() { }

        public override void PrintInfo()
        {
            Console.WriteLine($"Класс: Крестьянин с копьем\nИмя = {name}\nФамилия = {secondName}\nВозраст = {age}\nЗдоровье = {healPts}\nУрон = {damage}\nУдача = {luck}\nДеньги = {money} $");
        }
    }
}
