using System;

namespace Slutprojekt
{
    public class Clone
    {
        public int Armor{ get; protected set;}   //Properties for the clones stats
        public int Strength{ get; protected set;}
        public int Intelligence{ get; protected set;}
        public int Accuracy{ get; protected set;}

        protected static Random generator = new Random(); //Static generator that can be used in all of the subclasses to Clone
        public Clone() //Constructor that runs the Stats method that applies values to stats 
        {
            Stats();
        }

        public virtual void Stats() //Sets the base stats of the clone and its subclasses
        {
            Armor = 100;
            Strength = 100;
            Intelligence = 100;
            Accuracy = 100;
        }
    }
}
