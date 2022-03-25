using System;
using Damageables;
using DefaultNamespace;
using DG.Tweening;
using UnityEngine;
using Weapons;

namespace Ammunition
{
    public class BeeAmmunition : MonoBehaviour,IDamager,IAmmunition
    {
        public int Damage => 3;
        public float Speed => 0.5f;

        public void ApplyDamage(IDamageable target)
        {
            target.ApplyDamage(Damage);
        }
        
        public void DamageEffect()
        {
           Destroy(gameObject);
           //Note: we may apply here some particale 
        }
        
        public void Execute()
        {
            var playerPos = GameManager.Instance.Player.transform.position;
            transform.DOMove(playerPos,0.5f);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                ApplyDamage(GameManager.Instance.Player.GetComponent<IDamageable>());
                DamageEffect();
            }
        }
    }
}

