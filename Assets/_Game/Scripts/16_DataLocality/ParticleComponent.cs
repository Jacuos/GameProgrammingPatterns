using UnityEngine;

namespace DataLocality
{
    public class ParticleComponent : MonoBehaviour
    {
        public float speed=1;
        public void Render()
        {
            transform.position += Random.onUnitSphere * (speed * Time.deltaTime);
        }
    }
}