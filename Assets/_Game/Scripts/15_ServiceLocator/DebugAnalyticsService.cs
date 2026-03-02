using UnityEngine;

namespace ServiceLocator
{
    public class DebugAnalyticsService : IAnalyticsService
    {
        public void GameStarted()
        {
            Debug.Log("Analytics: Game Started");
        }

        public void GameEnded()
        {
            Debug.Log("Analytics: Game Ended");
        }

        public void CustomEvent(string eventName, object customParameter)
        {
            Debug.Log("Analytics: "+eventName+":"+customParameter);
        }
    }
}