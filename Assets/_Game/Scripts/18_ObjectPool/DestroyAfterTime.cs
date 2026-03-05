using System;
using System.Collections;
using UnityEngine;

namespace ObjectPooling
{
    public class DestroyAfterTime : MonoBehaviour
    {
        public float lifeTime = 5f;

        private void OnEnable()
        {
            StartCoroutine(Despawn());
        }

        IEnumerator Despawn()
        {
            yield return new WaitForSeconds(lifeTime);
            TestObjectPool.Instance.Despawn(this.gameObject);
        }
    }
}