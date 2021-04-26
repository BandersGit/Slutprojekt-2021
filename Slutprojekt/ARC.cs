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
            
            armor *= generator.Next(10, 20);
            armor /= 10;

            strength *= generator.Next(10, 20);
            strength /= 10;
            
            intelligence *= generator.Next(10, 20);
            intelligence /= 10;

            accuracy *= generator.Next(10, 20);
            accuracy /= 10;
        }
    }
}
