using UnityEngine;

namespace State
{
    public class CrouchState : HeroState
    {
        public override void Execute(Hero hero)
        {
            if(!Input.GetButton("Fire1"))
                hero.SetState(hero.standState);
        }

        public override void FixedExecute(Hero hero)
        {
            
        }

        public override void StartState(Hero hero)
        {
            hero.transform.localScale = new Vector3(1, 0.5f, 1);
        }

        public override void EndState(Hero hero)
        {
            hero.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}