using UnityEngine;

namespace SubclassSandbox
{
    public abstract class Superpower : MonoBehaviour
    {
        [SerializeField] protected GameObject source;
        [SerializeField] protected GameObject target;
        [SerializeField] protected ParticleSystem particle;
        
        public abstract void Activate();

        protected void Move(Vector3 position)
        {
            target.transform.position = position;
        }

        protected void PlayParticle()
        {
            particle.Play();
        }
    }
}