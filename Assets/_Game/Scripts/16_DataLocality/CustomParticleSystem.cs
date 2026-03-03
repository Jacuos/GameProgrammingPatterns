using System;
using UnityEngine;

namespace DataLocality
{
    public class CustomParticleSystem : MonoBehaviour
    {
        private ParticleComponent[] _particles;

        private void Awake()
        {
            _particles = GetComponentsInChildren<ParticleComponent>();
        }

        void Update()
        {
            for(int i=0;i<_particles.Length;i++)
                _particles[i].Render();
        }
    }
}