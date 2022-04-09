using Weapons;

namespace Attacker
{
    public interface IAttacker
    {
        IWeapon Weapon { get; set; }
        
    }
}
