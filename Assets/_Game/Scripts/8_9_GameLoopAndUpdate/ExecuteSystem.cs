using UnityEngine;

namespace GameLoop
{
    public abstract class ExecuteSystem : MonoBehaviour
    {
        public abstract void Execute(float deltaTime);
    }
}