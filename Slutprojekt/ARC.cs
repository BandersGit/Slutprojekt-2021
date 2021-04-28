using System;

namespace Slutprojekt
{
    public class ARC : Clone
    {
        public ARC()
        {
            Stats();
        }

        public override void Stats()
        {
            base.Stats();
            
            Armor *= generator.Next(10, 20);
            Armor /= 10;

            Strength *= generator.Next(10, 20);
            Strength /= 10;
            
            Intelligence *= generator.Next(10, 20);
            Intelligence /= 10;

            Accuracy *= generator.Next(10, 20);
            Accuracy /= 10;
        }
    }
}
