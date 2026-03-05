using UnityEngine;
using UnityEngine.Pool;
using Singleton;

namespace ObjectPooling
{
    public class TestObjectPool :Singleton<TestObjectPool>
    {
        [SerializeField] private GameObject _prefab;
        private ObjectPool<GameObject> _objectPool;

        void Awake()
        {
            _objectPool = new ObjectPool<GameObject>(
                createFunc: CreateItem,
                actionOnGet: OnGet,
                actionOnRelease: OnRelease,
                actionOnDestroy: OnDestroyItem,
                collectionCheck: true,   // helps catch double-release mistakes
                defaultCapacity: 10,
                maxSize: 50
            );
        }

        public void Despawn(GameObject go)
        {
            _objectPool.Release(go);
        }
        
        public GameObject InstantiateItem(Vector3 position, Quaternion rotation)
        {
            var newObject = _objectPool.Get();
            newObject.transform.position = position;
            newObject.transform.rotation = rotation;
            return newObject;
        }

        private void OnDestroyItem(GameObject obj)
        {
            Destroy(gameObject);
        }

        private void OnRelease(GameObject obj)
        {
            obj.SetActive(false);
        }

        private void OnGet(GameObject obj)
        {
            obj.SetActive(true);
        }

        private GameObject CreateItem()
        {
            return Instantiate(_prefab);
        }
    }
}