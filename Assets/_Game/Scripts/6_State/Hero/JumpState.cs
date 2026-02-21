using UnityEngine;

namespace State
{
    public class JumpState : HeroState
    {
        private Rigidbody _rigidbody;
        public override void Execute(Hero hero)
        {

        }

        public override void FixedExecute(Hero hero)
        {
            if(_rigidbody.IsSleeping())
                hero.SetState(hero.standState);
        }

        public override void StartState(Hero hero)
        {
            _rigidbody = hero.GetComponent<Rigidbody>();
            _rigidbody.AddForce(Vector3.up*8, ForceMode.Impulse);
        }

        public override void EndState(Hero hero)
        {
            
        }
    }
}