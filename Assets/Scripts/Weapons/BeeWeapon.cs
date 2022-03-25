using Ammunition;

namespace Weapons
{
    public class BeeWeapon : ShootingWeapon
    {
        public void Attack()
        {
            if (!CanAttack)
                return;
            var tempAmmunition = Instantiate(ammunition,ammunitionParent);
            tempAmmunition.GetComponent<IAmmunition>().Execute();
            //numberOfBullets--;
        }
    }
}
