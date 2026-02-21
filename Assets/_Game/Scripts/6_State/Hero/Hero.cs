using System;
using UnityEngine;

namespace State
{
    public class Hero : MonoBehaviour
    {
        public HeroState currentState;
        public HeroState standState;
        public HeroState jumpState;
        public HeroState crouchState;

        private void Awake()
        {
            standState = new StandState();
            jumpState = new JumpState();
            crouchState = new CrouchState();
            SetState(standState);
        }

        void Update()
        {
            currentState.Execute(this);    
        }

        void FixedUpdate()
        {
            currentState.FixedExecute(this);
        }

        public void SetState(HeroState newState)
        {
            if(currentState != null)
                currentState.EndState(this);
            currentState = newState;
            currentState.StartState(this);
        }
    }
}