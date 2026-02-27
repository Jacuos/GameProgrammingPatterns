using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Component
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] private Transform _flipView;
        
        private Rigidbody2D _rigidbody2D;
        private Vector3 _dirVector = Vector3.one;

        void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if(Mathf.Abs(_rigidbody2D.linearVelocity.x) > 0.01f)
                _dirVector.x = _rigidbody2D.linearVelocity.x >= 0 ? 1f : -1f;
            _flipView.localScale = _dirVector;
        }
    }
}