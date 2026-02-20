using System.Collections.Generic;
using UnityEngine;

namespace Observer
{
    public class Subject
    {
        private List<IObserver> _myObservers = new List<IObserver>();

        public void AddObserver(IObserver o)
        {
            _myObservers.Add(o);
        }

        public void Notify(GameObject source, ObserverEventType eventType)
        {
            for(int i=_myObservers.Count-1;i>=0;i--)
                _myObservers[i].OnNotify(source, eventType);
        }

        public void RemoveObserver(IObserver o)
        {
            if(_myObservers.Contains(o))
                _myObservers.Remove(o);
        }
    }
}