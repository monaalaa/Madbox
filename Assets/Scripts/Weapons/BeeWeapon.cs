using Ammunition;
using UnityEngine;

namespace Weapons
{
    public class BeeWeapon : ShootingWeapon
    {
        private GameObject tempAmmunition;
        public override void Attack()
        {
            if (!CanAttack)
                return;
            if (tempAmmunition == null)
            {
                tempAmmunition = Instantiate(ammunition,ammunitionParent);
            }
            else
            {
                tempAmmunition.transform.position=Vector3.zero;
                tempAmmunition.SetActive(true);
            }
            tempAmmunition.GetComponent<IAmmunition>().Execute();
            //numberOfBullets--;
        }
    }
}
