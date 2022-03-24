using System.Collections.Generic;
using UnityEngine;

namespace Enemies.Spawner
{
    public class EnemiesSpawnerView : MonoBehaviour
    {
        public List<GameObject> enemies = new List<GameObject>();
        public Transform enemiesParent;
    }
}
