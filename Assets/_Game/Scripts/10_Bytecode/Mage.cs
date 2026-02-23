using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Mage : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private Image _healthFill;
        public int health = 100;
        private int _maxHealth = 100;

        private void Awake()
        {
            UpdateBar();
        }

        public void ChangeHealth(int amount)
        {
            health = amount;
            UpdateBar();
        }

        void UpdateBar()
        {
            _healthFill.fillAmount = (float)health / _maxHealth;
            _healthText.text = health.ToString();
        }
    }
}