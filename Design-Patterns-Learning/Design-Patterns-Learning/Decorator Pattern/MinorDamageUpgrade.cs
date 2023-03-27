using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Decorator_Pattern
{
    internal class MinorDamageUpgrade : DamageDecorator
    {
        Weapon weapon;
        public MinorDamageUpgrade(Weapon weapon, int damage) :base(weapon,damage)
        {
            this.weapon = weapon;
        }

        public override int GetDamage()
        {
           return damage + weapon.GetDamage();
        }
    }
}
