using System;
using Component;
using UnityEngine;

namespace ServiceLocator
{
    public class PlayerAnalytics : MonoBehaviour
    {
        private PlayerMovement _playerMovement;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
            _playerMovement.Jumped += OnPlayerJumped;
        }

        private void OnPlayerJumped()
        {
            AnalyticsServiceLocator.GetService().CustomEvent("PLAYER_JUMPED",null);
        }

        private void OnDestroy()
        {
            if(_playerMovement != null)
                _playerMovement.Jumped -= OnPlayerJumped;
        }
    }
}