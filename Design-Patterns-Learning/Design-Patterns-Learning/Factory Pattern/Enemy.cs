using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Factory_Pattern
{
    internal abstract class Enemy
    {
        public string description = "default";
        public int health;
        public int damage;

        public Enemy()
        {

        }

        public abstract void PerformAttack();
        public void SetDescription(String description)
        {
            this.description = description;
        }

    }
}
