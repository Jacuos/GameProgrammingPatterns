using System;
using System.Collections.Generic;
using System.Linq;
using Singleton;
using UnityEngine;

namespace EventQueue
{
    public class SoundManager : Singleton<SoundManager>
    {
        [SerializeField]
        private SoundConfig _soundConfig;
        private AudioSource _audioSource;
        private Queue<SoundEntry> _soundQueue;

        protected void Awake()
        {
            base.Awake();
            _audioSource = GetComponent<AudioSource>();
            _soundQueue = new Queue<SoundEntry>();
        }
        
        public void PlaySound(SoundType soundType)
        {
            var soundEntry = _soundConfig.sounds.First(e=>e.type == soundType);
            if(_soundQueue.Contains(soundEntry))
                return;
            _soundQueue.Enqueue(soundEntry);
        }

        private void Update()
        {
            if(_soundQueue.Count == 0)
                return;
            var soundEntry = _soundQueue.Dequeue();
            _audioSource.PlayOneShot(soundEntry.audioClip, soundEntry.volume);
        }
    }
}