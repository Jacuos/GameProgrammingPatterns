using System;
using UnityEngine;

namespace ObjectPooling
{
    public class Hero : MonoBehaviour
    {
        private void Update()
        {
            Vector3 dir = Vector3.right*Input.GetAxisRaw("Horizontal");
            dir += Vector3.up*Input.GetAxisRaw("Vertical");
            dir.Normalize();
            transform.position += dir*Time.deltaTime;
        }
    }
}