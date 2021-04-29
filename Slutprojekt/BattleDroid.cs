using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class BattleDroid
    {
        protected Dictionary<string, int> enemyStats = new Dictionary<string, int>(); //A dictionary that stores a string and an int that will correlate to the enemies stats.

        public BattleDroid() //Constructor that creates the values for the Dictionary variables.
        {
            enemyStats.Add("armor", 100);
            enemyStats.Add("obedience", 100);
            enemyStats.Add("accuracy", 100);
        }
    }
}
