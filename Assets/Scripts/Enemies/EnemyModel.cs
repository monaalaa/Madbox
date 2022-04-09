using UnityEngine;
using Weapons;

namespace Enemies
{
    [CreateAssetMenu(fileName = "Data",menuName = "Enemy",order = 0)]
    public class EnemyModel : ScriptableObject
    {
        public GameObject model;
        public int health;
      
        public string generatedWeaponAfterDeath; 
        [HideInInspector] public string playerTag = "Player";
    }
}
