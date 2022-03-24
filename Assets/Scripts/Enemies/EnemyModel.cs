using UnityEngine;
using UnityEngine.Serialization;

namespace Enemies
{
    [CreateAssetMenu(fileName = "Data",menuName = "Enemy",order = 0)]
    public class EnemyModel : ScriptableObject
    {
        public GameObject model;
        public int AttackPower;
        public int AttackRange;
        public string GeneratedWeaponAfterDeath;
       [HideInInspector] public string PlayerTag = "Player";
    }
}
