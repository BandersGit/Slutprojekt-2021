using System;

namespace Slutprojekt
{
    public class ATKCommando : Commando
    {
        public ATKCommando() //Constructor that calls on Stats
        {
            Stats();
        }

        public override void Stats() //No random values set this time, just some boosted stats other less. 
        {
            
            Armor = 200;
            Strength = 200;
            Intelligence = 100;
            Accuracy = 100;
        }
    }
}
