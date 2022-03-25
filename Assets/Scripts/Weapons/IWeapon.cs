namespace Weapons
{
    public interface IWeapon
    {
        bool CanAttack { get;}
        void Attack();
    }
}
