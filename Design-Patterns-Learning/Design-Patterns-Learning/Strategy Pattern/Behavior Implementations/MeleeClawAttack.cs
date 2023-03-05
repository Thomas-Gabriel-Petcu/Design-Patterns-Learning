namespace Design_Patterns_Learning.Strategy_Pattern.Behavior_Implementations
{
    public class MeleeClawAttack : IMeleeAttackBehavior
    {
        public void MeleeAttack()
        {
            Console.WriteLine("Performed a claw attack");
        }
    }
}