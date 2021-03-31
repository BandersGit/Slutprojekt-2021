using System;

namespace Slutprojekt
{
    public class Clone
    {
        protected int armor;
        protected int strength;
        protected int intelligence;
        protected float accuracy;


        public Clone()
        {

        }

        public virtual void Stats()
        {
            armor = 100;
            strength = 100;
            intelligence = 100;

        }
    }
}
