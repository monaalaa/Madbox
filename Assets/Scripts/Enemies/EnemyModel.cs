using UnityEngine;

namespace Enemies
{
    [CreateAssetMenu(fileName = "Data",menuName = "Enemy",order = 0)]
    public class EnemyModel : ScriptableObject
    {
        public int AttackPower;
        public string GeneratedWeaponAfterDeath;
    }
}
