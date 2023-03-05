using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Strategy_Pattern
{
    public abstract class Enemy
    {
        public Enemy() { }
        public IMeleeAttackBehavior meleeAttackBehavior;

        public void PerformMeleeAttack()
        {
            meleeAttackBehavior.MeleeAttack();
        }
    }
}
