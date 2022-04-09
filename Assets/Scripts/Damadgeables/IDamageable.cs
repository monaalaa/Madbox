namespace Damageables
{
    public interface IDamageable
    {
        int Health { get; set; }
        void ApplyDamage(int damage);
    }
}
