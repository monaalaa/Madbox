namespace Weapons
{
    public interface IWeapon
    {
        float AttackRange { get; set; }
        bool CanAttack { get; set; }
        void Attack();
    }
}
