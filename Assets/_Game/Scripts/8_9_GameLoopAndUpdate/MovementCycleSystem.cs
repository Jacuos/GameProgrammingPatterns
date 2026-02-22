using System;
using UnityEngine;

namespace GameLoop
{
    public class MovementCycleSystem : ExecuteSystem
    {
        public Vector3 positionA;
        public Vector3 positionB;
        public float speed;
        private bool _targetA;
        private void Awake()
        {
            transform.position = positionA;
            _targetA = false;
        }

        public override void Execute(float deltaTime)
        {
            Vector3 targetPos = _targetA ? positionA : positionB;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * deltaTime);
            if(Vector3.Distance(transform.position, targetPos) <=0.01f)
                _targetA = !_targetA;
        }
    }
}