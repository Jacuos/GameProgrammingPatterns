using UnityEngine;

namespace State
{
    public class StandState : HeroState
    {
        public override void Execute(Hero hero)
        {
            if(Input.GetButton("Jump"))
                hero.SetState(hero.jumpState);
            else if(Input.GetButton("Fire1"))
                hero.SetState(hero.crouchState);
        }

        public override void FixedExecute(Hero hero)
        {
            
        }

        public override void StartState(Hero hero)
        {
            hero.transform.localScale = Vector3.one;
        }

        public override void EndState(Hero hero)
        {
            hero.transform.localScale = Vector3.one;
        }
    }
}