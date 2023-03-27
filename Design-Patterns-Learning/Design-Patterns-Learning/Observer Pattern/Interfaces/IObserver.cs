using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Learning.Observer_Pattern.Interfaces
{
    internal interface IObserver
    {
        public void UpdateObserver(ISubject subject);
    }
}
