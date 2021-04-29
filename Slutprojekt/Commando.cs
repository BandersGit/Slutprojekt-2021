using System;

namespace Slutprojekt
{
    public class Commando : ARC
    {
        public Commando() //Constructor that runs Stats method that does the same thing as the one in the ARC class
        {
            Stats();
        }

        public override void Stats()
        {
            base.Stats();
            
            Armor *= generator.Next(11, 21);
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
