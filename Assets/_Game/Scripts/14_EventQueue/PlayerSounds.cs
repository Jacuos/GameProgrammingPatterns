using System;
using System.Collections;
using Component;
using UnityEngine;

namespace EventQueue
{
    public class PlayerSounds : MonoBehaviour
    {
        private PlayerMovement _myPlayer;
        private Rigidbody2D _rigidbody2D;
        
        private void Awake()
        {
            _myPlayer = GetComponent<PlayerMovement>();
            _myPlayer.Jumped += OnJumped;
            _rigidbody2D = GetComponent<Rigidbody2D>();
            StartCoroutine(WalkCheck());
        }

        private void OnJumped()
        {
            SoundManager.Instance.PlaySound(SoundType.Jump);
        }
        
        IEnumerator WalkCheck()
        {
            yield return new WaitForSeconds(0.25f);
            if(Mathf.Abs(_rigidbody2D.linearVelocity.x) > 0.01f)
                SoundManager.Instance.PlaySound(SoundType.Move);
            StartCoroutine(WalkCheck());
        }

        private void OnDestroy()
        {
            _myPlayer.Jumped -= OnJumped;
        }
    }
}