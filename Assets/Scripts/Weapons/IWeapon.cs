namespace Weapons
{
    public interface IWeapon
    {
        bool CanAttack { get; set; }
        void Attack();
    }
}
