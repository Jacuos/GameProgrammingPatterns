using UnityEngine;

namespace Prototype
{
    public class Goblin : Monster
    {
        public override Monster Clone()
        {
            Debug.Log("Oh my! I spawned a Goblin that is so unique!");
            return base.Clone();
        }
    }
}