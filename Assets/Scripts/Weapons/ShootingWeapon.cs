using UnityEngine;
namespace Weapons
{
    public abstract class ShootingWeapon : MonoBehaviour,IWeapon
    {
        [SerializeField] protected GameObject ammunition;
        [SerializeField] protected int numberOfAmmunition;
        [SerializeField] protected Transform ammunitionParent;

        public float AttackRange { get; set; }

        public virtual bool CanAttack
        {
            get { return numberOfAmmunition > 0; }
            set { }
        }

        public virtual void Attack()
        {
            if (!CanAttack)
                return;
            //Instantiate()
            //numberOfBullets--;
        }
    }
}
