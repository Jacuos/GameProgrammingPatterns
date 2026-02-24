using UnityEngine;

namespace SubclassSandbox
{
    public class TeleportPower : Superpower
    {
        public Vector3 offset;
        public override void Activate()
        {
            PlayParticle();
            Move(target.transform.position + offset);
        }
    }
}