using System;
using UnityEngine;

namespace Damageables
{
    public abstract class Damageable:MonoBehaviour
    {
        public Action<int> ApplyDamage;
    }
}
