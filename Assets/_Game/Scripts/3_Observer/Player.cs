using System;
using UnityEngine;

namespace Observer
{
    public class Player : MonoBehaviour
    {
        public float speed=5;
        private Rigidbody _myRigidbody;
        public Subject fallEventSubject = new Subject();

        private void Awake()
        {
            _myRigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            Vector3 dir = Vector3.forward *Input.GetAxis("Vertical");
            dir += Vector3.right*Input.GetAxis("Horizontal");
            dir.Normalize();
            transform.position += dir * (speed * Time.deltaTime);
        }

        private void FixedUpdate()
        {
            if(_myRigidbody.linearVelocity.y<0)
                fallEventSubject.Notify(gameObject, ObserverEventType.IsFalling);
        }
    }
}