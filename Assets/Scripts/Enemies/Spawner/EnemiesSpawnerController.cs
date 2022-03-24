using System;
using UnityEngine;

namespace Enemies.Spawner
{
    public class EnemiesSpawnerController : MonoBehaviour
    {
        [SerializeField] private EnemiesSpawnerView view;

        private void Start()
        {
            SpawnEnemies();
        }
        private void SpawnEnemies()
        {
            Debug.Log(view.enemies.Count);
        }
    }
}
