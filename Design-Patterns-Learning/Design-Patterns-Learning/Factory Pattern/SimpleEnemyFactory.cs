using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Factory_Pattern
{
    internal static class SimpleEnemyFactory
    {
        public static Enemy CreateEnemy(String type)
        {
            if (type == "Knight")
            {
                return new Knight();
            }else if (type == "Mage")
            {
                return new Mage();
            }else if (type == "Boss")
            {
                return new Boss();
            }
            else
            {
                return null;
            }
        }
    }
}
