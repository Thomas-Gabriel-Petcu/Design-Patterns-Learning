using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Observer_Pattern
{
    internal abstract class Enemy
    {
        public int health;
        public int armor;
        public int damage;
        public bool isAsleep;
        public Enemy(int health, int armor, int damage, bool isAsleep)
        {
            this.health = health;
            this.armor = armor;
            this.damage = damage;
            this.isAsleep = isAsleep;

        }

        public virtual void WakeUp() { }


        public override string ToString()
        {
            return $"this enemy has {health} health, \n{armor} armor, \n{damage} damage,\nand is asleep: {isAsleep}";
        }
    }
}
