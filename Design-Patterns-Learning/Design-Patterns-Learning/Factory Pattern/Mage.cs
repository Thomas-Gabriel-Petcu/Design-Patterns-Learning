using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Factory_Pattern
{
    internal class Mage : Enemy
    {
        public Mage() 
        {
            this.health = 5;
            this.damage = 15;
        }
        public override void PerformAttack()
        {

        }
        public override string ToString()
        {
            return "Mage";
        }
    }
}
