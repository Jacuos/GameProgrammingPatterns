using UnityEngine;

namespace TypeObject
{
    public class Monster : MonoBehaviour
    {
        public Breed breed;
        public int currentHealth;

        void Awake()
        {
            currentHealth = breed.health;
            Attack();
        }

        void Attack()
        {
            Debug.Log(breed.attackDescription);
        }

    }
}