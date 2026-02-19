using UnityEngine;

namespace Command
{
    public class SpawnCommand : ICommand
    {
        private GameObject _prefab;
        private Vector3 _spawnPosition;
        private GameObject _mySpawnedObject;
        public SpawnCommand(GameObject prefab, Vector3 position)
        {
            _prefab = prefab;
            _spawnPosition = position;
        }
        
        public void Execute()
        {
            _mySpawnedObject = Object.Instantiate(_prefab, _spawnPosition, Quaternion.identity);
        }

        public void Undo()
        {
            Object.Destroy(_mySpawnedObject);
        }
    }
}