using Damageables;
using UnityEngine;

namespace Weapons
{
    public abstract class ColdWeapon : MonoBehaviour,IDamager,IWeapon
    {
        public virtual bool CanAttack
        {
            get => true;
            set { }
        }

        public int Damage { get; set; }
       
        public void Attack()
        {
        }
        
        public void ApplyDamage(IDamageable target)
        {
        }
        public void DamageEffect()
        {
        }
        
        
    }
}
