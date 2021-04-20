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
            armor = 100;
            strength = 100;
            intelligence = 100;
            accuracy = 100;
        }
    }
}
