using System;
using TMPro;
using UnityEngine;

namespace Observer
{
    public class AchievementsManager : MonoBehaviour, IObserver
    {
        [SerializeField]
        private TextMeshProUGUI _achievementsText;
        [SerializeField]
        private Player _player;

        private void OnEnable()
        {
            _achievementsText.text = "";
            _player.fallEventSubject.AddObserver(this);
        }


        public void OnNotify(GameObject source, ObserverEventType eventType)
        {
            if(source.GetComponent<Player>() && eventType is ObserverEventType.IsFalling)
                PlayFallingAchievement();
        }

        void PlayFallingAchievement()
        {
            _achievementsText.text = "Player Fell!";
            _player.fallEventSubject.RemoveObserver(this);
        }

        private void OnDisable()
        {
            _player.fallEventSubject.RemoveObserver(this);
        }
    }
}