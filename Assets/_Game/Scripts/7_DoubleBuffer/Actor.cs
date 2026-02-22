using UnityEngine;

namespace DoubleBuffer
{
    public class Actor : MonoBehaviour
    {
        private Actor _target;
        private bool _currentSlapped;
        private bool _nextSlapped;
        private float _lastSlapTimestamp;

        public void SetTarget(Actor target)
        {
            _target = target;
        }

        public void Slap()
        {
            _nextSlapped = true;
            _lastSlapTimestamp = Time.time;
        }

        public void SwapBuffer()
        {
            _currentSlapped = _nextSlapped;
            _nextSlapped = false;
        }
        
        public void Execute()
        {
            if (_currentSlapped)
            {
                Debug.Log(gameObject.name+": Ouch! I got Slapped! Now I Slap: "+_target.gameObject.name);
                _target.Slap();
            }
            else
                Debug.Log(gameObject.name+": Nothing happened.");
        }

        void Update()
        {
            if(Time.time <1)
                return;
            transform.localScale = Vector3.Lerp(Vector3.one*1.5f, Vector3.one, (Time.time - _lastSlapTimestamp)*2f);
        }
        
    }
}