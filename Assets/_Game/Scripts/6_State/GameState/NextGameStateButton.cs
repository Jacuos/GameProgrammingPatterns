using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace State
{
    [RequireComponent(typeof(Button))]
    public class NextGameStateButton : MonoBehaviour
    {
        [SerializeField] private int stateDir = 1;
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            int newState = (int)GameStateManager.Instance.currentGameState + stateDir;
            newState = Mathf.Clamp(newState, 0,(int)Enum.GetValues(typeof(GameState)).Cast<GameState>().Last());
            GameStateManager.Instance.ChangeState((GameState)newState);
        }
    }
}