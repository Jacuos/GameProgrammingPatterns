using UnityEngine;

namespace Flyweight
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private World _world;
        public float speed=5;
        void Update()
        {
            Vector3 dir = Vector3.up *Input.GetAxis("Vertical");
            dir += Vector3.right*Input.GetAxis("Horizontal");
            dir.Normalize();
            transform.position += dir * (speed * Time.deltaTime/_world.GetMovementCost(transform.position));
        }
    }
}