using System;

namespace Slutprojekt
{
    public class Clone
    {
        public int Armor{ get; protected set;}
        public int Strength{ get; protected set;}
        public int Intelligence{ get; protected set;}
        public int Accuracy{ get; protected set;}

        protected static Random generator = new Random();

        private string Name{ get; set;}

        public Clone()
        {
            Stats();
        }

        public string GetName()
        {
            return Name;
        }

        public virtual void Stats()
        {
            Armor = 100;
            Strength = 100;
            Intelligence = 100;
            Accuracy = 100;
        }
    }
}
