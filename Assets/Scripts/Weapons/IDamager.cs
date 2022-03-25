using Damageables;

namespace Weapons
{
    public interface IDamager
    {
        int Damage { get; }
        void ApplyDamage(IDamageable target);
        void DamageEffect();
    }
}
