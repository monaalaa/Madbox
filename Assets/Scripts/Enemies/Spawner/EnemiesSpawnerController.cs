using UnityEngine;

namespace Enemies.Spawner
{
    public class EnemiesSpawnerController : MonoBehaviour
    {
        [SerializeField] private EnemiesSpawnerView view;
        private EnemiesSpawnerData data = new EnemiesSpawnerData();
        private void Start()
        {
            SpawnEnemies();
        }
        private void SpawnEnemies()
        {
            for (int i = 0; i < data.NumberOfEnemies; i++)
            {
                var randX = Random.Range(-1 * data.SpawnXLimitation,data.SpawnXLimitation);
                var randZ = Random.Range(-1 * data.SpawnZLimitation,data.SpawnZLimitation);

                var enemy = Random.Range(0,view.enemies.Count);
                Vector3 pos = new Vector3(randX,1,randZ);
                
                Instantiate(view.enemies[enemy],pos,Quaternion.identity,view.enemiesParent);
            }
        }
    }
}
