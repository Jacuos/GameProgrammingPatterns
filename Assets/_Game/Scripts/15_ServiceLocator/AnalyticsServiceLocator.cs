using System;
using UnityEngine;

namespace ServiceLocator
{
    public class AnalyticsServiceLocator : MonoBehaviour
    {
        private static readonly IAnalyticsService _nullService = new NullAnalyticsService();
        private static IAnalyticsService _service = _nullService;
        
        public static void InjectService(IAnalyticsService service)
        {
            if(service != null)
                _service = service;
            else
                _service = _nullService;
        }

        public static IAnalyticsService GetService()
        {
            return _service;
        }

    }
}