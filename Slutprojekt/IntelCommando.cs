using System;

namespace Slutprojekt
{
    public class IntelCommando : Commando
    {
        public IntelCommando()
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
