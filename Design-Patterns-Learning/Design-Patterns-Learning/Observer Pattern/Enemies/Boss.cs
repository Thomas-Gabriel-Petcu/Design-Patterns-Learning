using Design_Patterns_Learning.Observer_Pattern.Interfaces;

namespace Design_Patterns_Learning.Observer_Pattern
{
    internal class Boss : Enemy, ISubject
    {
        bool changed = false;
        private List<IObserver> observers = new List<IObserver>();

        public Boss(int health, int armor, int damage, bool isAsleep) : base(health, armor, damage, isAsleep)
        {

        }

        public override void WakeUp()//boss wakes up when alerted by player
        {
            //notify minions
            this.isAsleep = false;
            SetChanged();
            UpdateObservers();
        }

        public void AddObserver(IObserver obs)
        {
            observers.Add(obs);
        }
        public void RemoveObserver(IObserver obs)
        {
            if (observers.Contains(obs))
            {
                observers.Remove(obs);
            }
        }
        public void UpdateObservers()
        {
            if (!changed) return;
            foreach (IObserver obs in observers)
            {
                obs.UpdateObserver(this);
            }
            changed = false;
        }
        public void SetChanged()
        {
            changed = true;
        }
    }
}
