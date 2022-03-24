using UnityEngine;

namespace Enemies
{
    [CreateAssetMenu(fileName = "Data",menuName = "Enemy",order = 0)]
    public class EnemyModel : ScriptableObject
    {
        public GameObject model;
        public int AttackPower;
        public string GeneratedWeaponAfterDeath;
    }
}
