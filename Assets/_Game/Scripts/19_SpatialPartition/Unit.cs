using UnityEngine;

namespace SpatialPartition
{
    public class Unit : MonoBehaviour
    {
        public Grid parentGrid;
        private Unit _previousUnit;
        private Unit _nextUnit;
    }
}