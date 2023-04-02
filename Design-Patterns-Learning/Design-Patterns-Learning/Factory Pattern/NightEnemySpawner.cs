using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Factory_Pattern
{
    internal static class NightEnemySpawner
    {
        public static bool CanSpawnEnemy()
        {
            //check for conditions
            return true;
        }

        public static Enemy SpawnEnemy(string type)
        {
            //logic to determine what enemy to spawn
            if (CanSpawnEnemy())
            {
                return SimpleEnemyFactory.CreateEnemy(type);
            }
            return null;
        }
    }
}
