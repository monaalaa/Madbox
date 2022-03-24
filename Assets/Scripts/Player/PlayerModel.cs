using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "PlayerData",menuName = "Player",order = 0)]
    public class PlayerModel : ScriptableObject
    {
         public int health;
         public string weaponName;
    }
}
