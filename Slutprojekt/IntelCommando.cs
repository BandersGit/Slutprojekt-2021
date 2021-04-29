using System;

namespace Slutprojekt
{
    public class IntelCommando : Commando
    {
        public IntelCommando() //Constructor that runs Stats
        {
            Stats();
        }

        public override void Stats() //Again no random values, just buffs in different areas to ATK
        {
            Armor = 100;
            Strength = 100;
            Intelligence = 200;
            Accuracy = 200;
        }
    }
}
