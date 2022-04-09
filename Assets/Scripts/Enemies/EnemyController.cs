using Attacker;
using Damageables;
using DG.Tweening;
using Managers;
using UnityEngine;
using Weapons;

namespace Enemies
{
    public abstract class EnemyController : MonoBehaviour,IDamageable,IAttacker
    {
        public EnemyView view;
        protected GameObject Target;
        private Vector3 _initialPosition;
        protected Coroutine AttackCoroutine;
        public IWeapon Weapon { get; set; }
        public int Health { get; set; }
        private void Awake()
        {
            EventsManager.PlayerStartMoving += ResetPosition;
            EventsManager.PlayerStopMoving += AttackPlayer;
        }
        private void Start()
        {
            Target = GameObject.FindWithTag(view.model.playerTag);
            _initialPosition = transform.position;
        }
        protected virtual void AttackPlayer()
        {
        }
        protected virtual void ResetPosition()
        {
            transform.DOMove(_initialPosition,0.5f);
        }
        private void OnDestroy()
        {
            EventsManager.PlayerStartMoving -= ResetPosition;
            EventsManager.PlayerStopMoving -= AttackPlayer;
        }
 
        public void ApplyDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Debug.Log("Die");
            }
        }
      
    }
}
