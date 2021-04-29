using System;

namespace Slutprojekt
{
    public class SuperBattleDroid : BattleDroid
    {
        public SuperBattleDroid() //Changes the int related to the string.
        {
            enemyStats["armor"] = 200;
            enemyStats["obedience"] = 200;
            enemyStats["accuracy"] = 200;
        }
    }
}
