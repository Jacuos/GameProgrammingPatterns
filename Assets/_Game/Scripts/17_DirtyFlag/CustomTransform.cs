using System;
using UnityEngine;

namespace DirtyFlag
{
    public class CustomTransform : MonoBehaviour
    {
        [SerializeField]
        private float radius = 1f;
        [SerializeField]
        [Range(0f, 1f)]
        private float alpha = 0.5f;
        private CustomTransform[] _children = new CustomTransform[100];
        private int _childrenCount;
        private bool _isDirty = true;
        public Vector3 localPosition;
        public Vector3 worldPosition;

        private void Awake()
        {
            _childrenCount = transform.transform.childCount;
            for(int i = 0; i < _childrenCount; i++)
                _children[i] = transform.GetChild(i).GetComponent<CustomTransform>();
        }

        public CustomTransform GetOrigin()
        {
            return transform.root.GetComponent<CustomTransform>();
        }

        public CustomTransform Combine(CustomTransform other)
        {
            return this;
        }

        public void Render(CustomTransform parentWorld, bool dirty)
        {
            dirty |= _isDirty;
            var world = parentWorld;
            if (dirty)
            {
                world = Combine(parentWorld);
                _isDirty = false;
            }
            for(int i=0;i<_childrenCount;i++)
                _children[i].Render(world,dirty);
        }

        public void Move(Vector3 position)
        {
            _isDirty = true;
            Render(this, true);
        }
        
        private void OnDrawGizmos()
        {
            // Set the color with custom alpha
            Gizmos.color = new Color(1f, 0f, 0f, alpha); // Red with custom alpha

            // Draw the sphere
            Gizmos.DrawSphere(worldPosition, radius);

            // Draw wire sphere outline
            Gizmos.color = Color.white;
            Gizmos.DrawWireSphere(worldPosition, radius);
        }
    }
}