using Design_Patterns_Learning.Observer_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Observer_Pattern
{
    internal class EnemyManager : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();
        public EnemyManager() { 

        }
        public void AddObserver(IObserver obs)
        {
            if(!_observers.Contains(obs)) _observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            if(_observers.Contains(obs)) _observers.Remove(obs);
        }

        public void UpdateObservers()
        {
            foreach (IObserver obs in _observers)
            {
                obs.UpdateObserver(this);
            }
        }
        public void SetChanged()
        {

        }
    }
}
