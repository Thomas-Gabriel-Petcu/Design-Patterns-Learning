using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Factory_Pattern
{
    internal class Knight : Enemy
    {
        public Knight()
        {
            this.health = 20;
            this.damage = 10;
        }

        public override void PerformAttack()
        {

        }
        public override string ToString()
        {
            return "Knight";
        }
    }
}
