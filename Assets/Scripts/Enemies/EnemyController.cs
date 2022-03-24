using DG.Tweening;
using Managers;
using UnityEngine;

namespace Enemies
{
    public abstract class EnemyController : MonoBehaviour
    {
        public EnemyView view;
        protected GameObject _target;
        private Vector3 _initialPosition;
        protected Coroutine _attackCoroutine;
        private void Awake()
        {
            EventsManager.PlayerStartMoving += ResetPosition;
            EventsManager.PlayerStopMoving += AttackPlayer;
        }
        private void Start()
        {
            _target = GameObject.FindWithTag(view.Model.PlayerTag);
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
    }
}
