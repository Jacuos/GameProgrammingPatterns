using System;
using UnityEngine;

namespace Singleton
{
    public class MatchManager : Singleton<MatchManager>
    {
        [HideInInspector]
        public float remainingMatchTime;
        [SerializeField] private float _maxMatchTime;

        void Awake()
        {
            remainingMatchTime = _maxMatchTime;
        }

        private void Update()
        {
            remainingMatchTime -= Time.deltaTime;
            remainingMatchTime = Mathf.Clamp(remainingMatchTime, 0, _maxMatchTime);
        }
    }
}