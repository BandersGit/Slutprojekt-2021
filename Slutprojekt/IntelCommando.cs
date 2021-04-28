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
            Armor = 100;
            Strength = 100;
            Intelligence = 200;
            Accuracy = 200;
        }
    }
}
