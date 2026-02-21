using System;
using System.Collections;
using UnityEngine;

namespace Prototype
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Monster _monsterPrefab;
        [SerializeField] private float _spawnInterval;
        private void Start()
        {
            StartCoroutine(SpawnDelayed());
        }

        IEnumerator SpawnDelayed()
        {
            yield return new WaitForSeconds(_spawnInterval);
            var newMonster = _monsterPrefab.Clone();
            newMonster.transform.position = transform.position;
            StartCoroutine(SpawnDelayed());
        }
    }
}