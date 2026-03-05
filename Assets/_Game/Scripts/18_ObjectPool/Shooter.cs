using UnityEngine;

namespace ObjectPooling
{
    public class Shooter : MonoBehaviour
    {
        public float shootSpeed=1f;
        private float _lastShotTimestamp;
        
        void Update()
        {
            if(TestObjectPool.Instance == null)
                return;
            if(Time.time < _lastShotTimestamp + 1/shootSpeed)
                return;
            TestObjectPool.Instance.InstantiateItem(transform.position, transform.rotation);
            _lastShotTimestamp = Time.time;
        }
    }
}