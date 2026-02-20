using UnityEngine;

namespace Flyweight
{

    public class Terrain
    {
        private int _movementCost;
        private bool _isWater;
        private GameObject _prefab;

        public Terrain(int movementCost, bool isWater, GameObject prefab)
        {
            _movementCost = movementCost;
            _isWater = isWater;
            _prefab = prefab;
        }

        public int GetMovementCost()
        {
            return _movementCost;
        }

        public bool IsWater()
        {
            return _isWater;
        }

        public GameObject GetPrefab()
        {
            return _prefab;
        }
    }
}