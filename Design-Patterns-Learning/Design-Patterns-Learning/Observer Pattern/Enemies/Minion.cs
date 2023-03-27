using Design_Patterns_Learning.Observer_Pattern.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace Design_Patterns_Learning.Observer_Pattern.Enemies
{
    internal class Minion : Enemy, IObserver
    {
        List<ISubject> _subjects = new List<ISubject>();
        public Minion(int health, int armor, int damage, bool isAsleep, ISubject subject) : base(health, armor, damage, isAsleep)
        {
            _subjects.Add(subject);
            subject.AddObserver(this);
        }
        public void UpdateObserver(ISubject subject)
        {
            WakeUp();
            if (subject.GetType() == typeof(Boss))
            {
                Console.Write("subject is boss");
                //Boss boss = (Boss)subject;
            }
            else
            {
                Console.Write("subject is not boss");
            }

        }
        public override void WakeUp()
        {
            isAsleep = false;
        }
    }
}
