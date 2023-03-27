using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Decorator_Pattern
{
    internal abstract class Weapon
    {
        protected int damage;
        public abstract int GetDamage();
        public Weapon(int damage)
        {
            this.damage = damage;
        }
    }
}
