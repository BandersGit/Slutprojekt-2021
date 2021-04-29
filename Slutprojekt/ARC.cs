using System;

namespace Slutprojekt
{
    public class ARC : Clone
    {
        public ARC() //Constructor that runs Stats method
        {
            Stats(); 
        }

        public override void Stats() //Overrides the Stats method in Clone and applies changed versions of the values from the base class.
        {
            base.Stats();   //Calls on the base class Stats method to get the values so they can be changed.
            
            Armor *= generator.Next(11, 21);    //Times the base value of the variable with a random number from 11 to 20 and then divides by 10 to get a end value 0f 110 to 200.
            Armor /= 10;

            Strength *= generator.Next(11, 21);
            Strength /= 10;
            
            Intelligence *= generator.Next(11, 21);
            Intelligence /= 10;

            Accuracy *= generator.Next(11, 21);
            Accuracy /= 10;
        }
    }
}
