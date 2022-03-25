using UnityEngine;
namespace Weapons
{
    public abstract class ShootingWeapon : MonoBehaviour,IWeapon
    {
        [SerializeField] protected GameObject ammunition;
        [SerializeField] protected int numberOfAmmunition;
        [SerializeField] protected Transform ammunitionParent;
        public virtual bool CanAttack => numberOfAmmunition > 0;
      
        public void Attack()
        {
            if (!CanAttack)
                return;
            //Instantiate()
            //numberOfBullets--;
        }
    }
}
