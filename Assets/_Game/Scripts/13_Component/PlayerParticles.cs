using System;
using UnityEngine;

namespace Component
{
    public class PlayerParticles : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _jumpParticle;
        private PlayerMovement _playerMovement;
        void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
            _playerMovement.Jumped += OnJumped;
        }

        private void OnJumped()
        {
            _jumpParticle.Play();
        }

        private void OnDestroy()
        {
            if(_playerMovement != null)
                _playerMovement.Jumped -= OnJumped;
        }
    }
}