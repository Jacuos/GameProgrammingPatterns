using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Flyweight
{
    public class World : MonoBehaviour
    {
        [SerializeField] private Vector2Int _worldSize;
        [SerializeField] private GameObject _grassPrefab;
        [SerializeField] private GameObject _hillsPrefab;
        [SerializeField] private GameObject _riverPrefab;
        private Terrain[,] _board;
        private Terrain _grassTerrain;
        private Terrain _hillsTerrain;
        private Terrain _riverTerrain;
        private void Awake()
        {
            _grassTerrain = new Terrain(1,false,_grassPrefab);
            _hillsTerrain = new Terrain(3,false,_hillsPrefab);
            _riverTerrain = new Terrain(2,true,_riverPrefab);
            SpawnNewTerrain();
        }

        public int GetMovementCost(Vector3 worldPosition)
        {
            Vector3 local = transform.InverseTransformPoint(worldPosition);
            int x = Mathf.Clamp(Mathf.RoundToInt(local.x),0,_board.GetLength(0)-1);
            int y = Mathf.Clamp(Mathf.RoundToInt(local.y),0,_board.GetLength(1)-1);
            return _board[x, y].GetMovementCost();
        }
        void SpawnNewTerrain()
        {
            _board = new Terrain[_worldSize.x, _worldSize.y];
            int riverX = Random.Range(0, _worldSize.x);
            for (int x = 0; x < _worldSize.x; x++)
            {
                for (int y = 0; y < _worldSize.y; y++)
                {
                    if(x == riverX)
                        continue;
                    _board[x, y] = Random.value > 0.33f ? _grassTerrain : _hillsTerrain;
                    Instantiate(_board[x,y].GetPrefab(),transform.position+new Vector3(x,y,0), Quaternion.identity,transform);
                }
            }
            for (int y = 0; y < _worldSize.y; y++)
            {
                _board[riverX, y] = _riverTerrain;
                Instantiate(_board[riverX,y].GetPrefab(),transform.position+new Vector3(riverX,y,0), Quaternion.identity,transform);
            }

        }
    }
}