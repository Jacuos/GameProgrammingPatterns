using UnityEngine;

namespace Prototype
{
    public class Monster : MonoBehaviour
    {
        public virtual Monster Clone()
        {
            return Instantiate(this);
        }

        void Update()
        {
            transform.position += Vector3.back * Time.deltaTime;
        }
    }
}