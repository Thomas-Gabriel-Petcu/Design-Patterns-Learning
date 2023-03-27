using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Decorator_Pattern
{
    internal class Sword : Weapon
    {
        public Sword(int damage) : base(damage)
        {

        }
        public override int GetDamage()
        {
            return damage;
        }
    }
}
