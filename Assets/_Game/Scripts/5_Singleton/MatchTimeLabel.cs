using System;
using TMPro;
using UnityEngine;

namespace Singleton
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class MatchTimeLabel : MonoBehaviour
    {
        private TextMeshProUGUI _textLabel;
        private void Awake()
        {
            _textLabel = GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            _textLabel.text = "TIME REMAINING:\n"+Math.Round(MatchManager.Instance.remainingMatchTime,2);
        }
    }
}