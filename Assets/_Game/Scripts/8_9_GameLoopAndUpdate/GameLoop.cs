using System;
using UnityEngine;

namespace GameLoop
{
    public class GameLoop : MonoBehaviour
    {
        public ExecuteSystem[] variableSystems;
        public ExecuteSystem[] fixedSystems;

        private void Update()
        {
            foreach (var system in variableSystems)
            {
                system.Execute(Time.deltaTime);
            }
        }


        private void FixedUpdate()
        {
            foreach (var system in fixedSystems)
            {
                system.Execute(Time.fixedDeltaTime);
            }
        }
    }
}