namespace Design_Patterns_Learning.Strategy_Pattern.Behavior_Implementations
{
    public class MeleeBiteAttack : IMeleeAttackBehavior
    {
        public void MeleeAttack()
        {
            Console.WriteLine("Performed a bite attack");
        }
    }
}