using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace DoubleBuffer
{
    public class Stage : MonoBehaviour
    {
        [SerializeField]
        private Actor[] _actors;
        private Actor[] _scrambledActors;
        private void Awake()
        {
            SetActorTargets();
            ScrambleActorsOrder();
            _scrambledActors[0].Slap();
            StartCoroutine(DelayedUpdate());
        }

        void SetActorTargets()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                int targetiD = i + 1;
                if (targetiD >= _actors.Length)
                    targetiD = 0;
                _actors[i].SetTarget(_actors[targetiD]);
            }
        }

        void ScrambleActorsOrder()
        {
            _scrambledActors = new Actor[_actors.Length];
            Random r = new Random();
            int j = 0;
            foreach (int i in Enumerable.Range(0, _actors.Length).OrderBy(x => r.Next()))
            {
                _scrambledActors[j] = _actors[i];
                j++;
            }
        }

        IEnumerator DelayedUpdate()
        {
            yield return new WaitForSecondsRealtime(1f);
            for(int i = 0; i < _scrambledActors.Length; i++)
                _scrambledActors[i].Execute();
            for(int i = 0; i < _scrambledActors.Length; i++)
                _scrambledActors[i].SwapBuffer();
            StartCoroutine(DelayedUpdate());
        }
        
        
        
    }
}