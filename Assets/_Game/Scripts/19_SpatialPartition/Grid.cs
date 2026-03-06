using System;
using UnityEngine;

namespace SpatialPartition
{
    //UUUU I'm storing units on a grid, I am so smart
    public class Grid : MonoBehaviour
    {
        public Vector2Int gridSize;
        public Unit[,] grid;

        private void Awake()
        {
            grid = new Unit[gridSize.x, gridSize.y];
        }
    }
}