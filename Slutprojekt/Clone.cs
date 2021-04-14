using System;

namespace Slutprojekt
{
    public class Clone
    {
        public int armor{ get; private set;}
        protected int strength{ get; private set;}
        protected int intelligence{ get; private set;}
        protected float accuracy{ get; private set;}


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
