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
            
            armor = 200;
            strength = 200;
            intelligence = 100;
            accuracy = 100;
        }
    }
}
