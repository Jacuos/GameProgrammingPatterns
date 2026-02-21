using System;
using TMPro;
using UnityEngine;

namespace State
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class CurrentGameStateLabel : MonoBehaviour
    {
        private TextMeshProUGUI _text;
        private void Awake()
        {
            _text = GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            GameStateManager.GameStateChanged += OnGameStateChanged;
            OnGameStateChanged(GameStateManager.Instance.currentGameState);
        }

        private void OnGameStateChanged(GameState obj)
        {
            _text.text = obj.ToString();
        }

        private void OnDisable()
        {
            GameStateManager.GameStateChanged -= OnGameStateChanged;
        }
    }
}