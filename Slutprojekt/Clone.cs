using System;

namespace Slutprojekt
{
    public class Clone
    {
        public int armor{ get; protected set;}
        public int strength{ get; protected set;}
        public int intelligence{ get; protected set;}
        public float accuracy{ get; protected set;}

        private string name{ get; set;}
        public string GetName()
        {
            return name;
        }

        public Clone()
        {
            Stats();
        }

        public virtual void Stats()
        {
            armor = 100;
            strength = 100;
            intelligence = 100;
            accuracy = 100;
        }
    }
}
