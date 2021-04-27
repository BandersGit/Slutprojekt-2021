using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class BattleDroid
    {
        protected Dictionary<string, int> enemyStats = new Dictionary<string, int>();

        public BattleDroid()
        {
            enemyStats.Add("armor", 100);
            enemyStats.Add("obedience", 100);
            enemyStats.Add("accuracy", 100);
        }
    }
}
