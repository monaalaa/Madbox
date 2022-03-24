using DG.Tweening;

namespace Weapons
{
    public class BeeWeapon : Weapon
    {
        public override void Execute()
        {
            transform.DOMove(Target,0.5f);
        }
    }
}
