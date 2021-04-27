using System;

namespace Slutprojekt
{
    public class SuperBattleDroid : BattleDroid
    {
        public SuperBattleDroid()
        {
            enemyStats["armor"] = 200;
            enemyStats["obedience"] = 200;
            enemyStats["accuracy"] = 200;
        }
    }
}
