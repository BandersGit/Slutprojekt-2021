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
            
            Armor = 200;
            Strength = 200;
            Intelligence = 100;
            Accuracy = 100;
        }
    }
}
