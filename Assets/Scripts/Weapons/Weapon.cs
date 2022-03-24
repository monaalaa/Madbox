using Damageables;
using UnityEngine;

namespace Weapons
{
    public abstract class Weapon : MonoBehaviour
    { 
        public int attackPower;
        protected Vector3 Target;
        private string _targetTag;
       
        public void InitWeapon(Vector3 target, string targetTag)
        {
            Target = target;
            _targetTag = targetTag;
        }
      
        public virtual void Execute()
        {
        }
        
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(_targetTag))
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
