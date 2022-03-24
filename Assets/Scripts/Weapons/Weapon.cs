using System;
using Damageables;
using UnityEngine;

namespace Weapons
{
    public abstract class Weapon : MonoBehaviour
    { 
        public int attackPower;
        protected Transform Target;
        protected string TargetTag;
       
        public void InitWeapon(Transform target, string targetTag)
        {
            Target = target;
            TargetTag = targetTag;
        }
      
        public virtual void Execute()
        {
        }
        
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(TargetTag))
            {
                ApplyCollisionEffect();
                collision.gameObject.GetComponent<Damageable>().ApplyDamage?.Invoke(attackPower);
            }
        }

        public virtual void ApplyCollisionEffect()
        {
            Destroy(gameObject);
        }
    }
}
