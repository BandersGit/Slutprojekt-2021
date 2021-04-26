using System;

namespace Slutprojekt
{
    public class ATKCommando : Commando
    {
        public ATKCommando()
        {
            Stats();
        }

        public override void Stats()
        {
            
            armor = 100;
            strength *= generator.Next(10, 20);
            strength /= 10;
            intelligence = 100;
            accuracy = 100;
        }
    }
}
