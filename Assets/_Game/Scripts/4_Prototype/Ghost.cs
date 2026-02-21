using UnityEngine;

namespace Prototype
{
    public class Ghost : Monster
    {
        public override Monster Clone()
        {
            Debug.Log("Oh my! I spawned a Ghost that is so unique!");
            return base.Clone();
        }
    }
}