using System;
using UnityEngine;

namespace Component
{
    public class PlayerMovement : MonoBehaviour
    {
        public Action Jumped;
        public float movementSpeed = 6f;
        public float jumpForce = 10f;
        private Rigidbody2D _rigidbody;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            var horizontal = Input.GetAxisRaw("Horizontal");
            _rigidbody.linearVelocity = new Vector2(horizontal * movementSpeed, _rigidbody.linearVelocity.y);
            if (Input.GetButtonDown("Jump"))
            {
                _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                Jumped?.Invoke();
            }
        }
        
    }
}