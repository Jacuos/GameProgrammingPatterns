using System;
using UnityEngine;
using Singleton;

namespace State
{
    public class GameStateManager : Singleton<GameStateManager>
    {
        public static Action<GameState> GameStateChanged;
        public GameState currentGameState;
        protected void Awake()
        {
            base.Awake();
        }

        public void ChangeState(GameState newGameState)
        {
            currentGameState = newGameState;
            GameStateChanged?.Invoke(currentGameState);
        }
    }
}