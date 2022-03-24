using UnityEngine;

namespace Enemies
{
    [CreateAssetMenu(fileName = "Data",menuName = "Enemy",order = 0)]
    public class EnemyModel : ScriptableObject
    {
        public GameObject model;
        public GameObject weapon;
        public int health;
        public int attackRange;
        public string generatedWeaponAfterDeath; 
        [HideInInspector] public string playerTag = "Player";
    }
}
