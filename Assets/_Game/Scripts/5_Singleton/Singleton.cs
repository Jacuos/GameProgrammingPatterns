using Unity.VisualScripting;
using UnityEngine;

namespace Singleton
{
    public class Singleton <T> : MonoBehaviour where T : class
    {
        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindFirstObjectByType(typeof(T)) as T;
                return _instance;
            }
        }
        private static T _instance;

        void Awake()
        {
            if(_instance == null)
                _instance = this as T;
        }
    }
}