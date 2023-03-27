namespace Design_Patterns_Learning
{
    //using Observer_Pattern.Enemies;
    //using Observer_Pattern.Interfaces;
    //using Strategy_Pattern;
    //using Strategy_Pattern.Behavior_Implementations;
    //using Observer_Pattern;
    using Decorator_Pattern;

    internal class Program
    {

        static void Main(string[] args)
        {
            //For executing the patterns demos uncomment
            //respective imports!

            #region Strategy Pattern
            //Enemy z = new Zombie();
            //z.SetMeleeAttackBehavior(new MeleeBiteAttack());
            //z.PerformMeleeAttack();
            //z.SetMeleeAttackBehavior(new MeleeClawAttack());
            //z.PerformMeleeAttack();
            #endregion

            #region Observer Pattern
            //Enemy boss = new Boss(100,10,10,true);
            //Enemy minion = new Minion(10, 1, 1, true, (Boss)boss);

            //Console.Write(boss + "\n");
            //Console.Write(minion + "\n");
            //boss.WakeUp();
            //Console.Write(boss + "\n");
            //Console.Write(minion);
            #endregion

            #region Decorator Pattern
            List<Weapon> weapons = new List<Weapon>();

            Weapon sword = new Sword(10);
            Weapon longsword = new Sword(40);

            sword = new MinorDamageUpgrade(sword,5);
            longsword = new MinorDamageUpgrade(longsword,40);

            weapons.Add(sword); weapons.Add(longsword);

            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine(weapon.GetDamage());
            }

            #endregion

        }
    }
}