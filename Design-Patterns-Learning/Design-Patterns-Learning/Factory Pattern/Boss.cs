using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Factory_Pattern
{
    internal class Boss : Enemy
    {
        public string minion = "default";
        public List<Enemy> minions = new List<Enemy>();
        public Boss()
        {
            this.health = 100;
            this.damage = 20;
        }

        public override void PerformAttack()
        {
            
        }
        public void SetMinion(string minion)
        {
            
            this.minion = minion;
        }
        
        public void SummonMinion()
        {
            if (minion == "default") return;
            minions.Add(SimpleEnemyFactory.CreateEnemy(minion));
        }
    }
}
