using System.ComponentModel;
using UnityEngine;

namespace DirtyFlag
{
    public class WorldGraph : MonoBehaviour
    {
        public CustomTransform rootNode;
        public Vector3 moveVector;
        public CustomTransform moveNode;
        void Start()
        {
            rootNode.Render(rootNode.GetOrigin(),true);
        }
        
        public void Move()
        {
            moveNode.Move(moveVector);
        }
    }
}