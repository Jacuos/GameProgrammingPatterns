using UnityEngine;

namespace ObjectPooling
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 10.0f;
        void Update()
        {
            transform.position += transform.forward * (speed * Time.deltaTime);
        }
    }
}