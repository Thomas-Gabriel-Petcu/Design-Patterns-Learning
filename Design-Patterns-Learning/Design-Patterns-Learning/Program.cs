namespace Design_Patterns_Learning
{
    using Strategy_Pattern;
    using Strategy_Pattern.Behavior_Implementations;
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Zombie z = new Zombie();
            z.SetMeleeAttackBehavior(new MeleeBiteAttack());
            z.PerformMeleeAttack();
            z.SetMeleeAttackBehavior(new MeleeClawAttack());
            z.PerformMeleeAttack();

        }
    }
}