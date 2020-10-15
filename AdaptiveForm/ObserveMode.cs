using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveForm
{
    public abstract class Observer
    {
        public virtual void Response() { }
    }
    public abstract class Subject
    {
        List<Observer> ObserverList = new List<Observer>();
        public virtual void AddObserver(Observer o)
        {
            this.ObserverList.Add(o);
        }
    }
}
