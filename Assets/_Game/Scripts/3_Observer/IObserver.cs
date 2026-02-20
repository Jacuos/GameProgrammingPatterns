using UnityEngine;

namespace Observer
{
    public interface IObserver
    {
        public void OnNotify(GameObject source,ObserverEventType eventType);
    }
}