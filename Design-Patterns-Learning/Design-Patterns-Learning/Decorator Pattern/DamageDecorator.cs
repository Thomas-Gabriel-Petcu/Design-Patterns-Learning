using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Decorator_Pattern
{
    internal class DamageDecorator : Weapon
    {
        Weapon weapon;
        public DamageDecorator(Weapon weapon, int damage) : base(damage)
        {
            this.weapon = weapon;
        }

        public override int GetDamage()
        {
            return damage + weapon.GetDamage();
        }
    }
}
