using UnityEngine;

namespace SubclassSandbox
{
    public class PushPower : Superpower
    {
        public float force;
        public override void Activate()
        {
            var body = target.GetComponent<Rigidbody>();
            var dir = target.transform.position - source.transform.position;
            dir.Normalize();
            body.AddForce(dir * force,ForceMode.Impulse);
        }
    }
}