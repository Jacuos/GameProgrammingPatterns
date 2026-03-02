using System;
using UnityEngine;

namespace ServiceLocator
{
    public class AnalyticsManager : MonoBehaviour
    {
        private void Awake()
        {
            AnalyticsServiceLocator.InjectService(new DebugAnalyticsService());
        }

        void Start()
        {
            AnalyticsServiceLocator.GetService().GameStarted();
            
        }

        private void OnDestroy()
        {
            AnalyticsServiceLocator.GetService().GameEnded();
        }
    }
}