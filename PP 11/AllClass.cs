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
    }
}
