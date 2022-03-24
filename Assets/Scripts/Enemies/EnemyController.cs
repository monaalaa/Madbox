using DG.Tweening;
using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private EnemyView view;
        private GameObject _target;
        private Vector3 _initialPosition;
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
        private void Update()
        {
            transform.LookAt(_target.transform);
        }
        
        private void AttackPlayer()
        {
            var targetPosition = _target.transform.position;
            var distance = Vector3.Distance (transform.position,targetPosition );
            
            if (distance < view.Model.AttackRange)
            {
                Vector3 dir = (this.transform.position - targetPosition).normalized;
                targetPosition=  _target.transform.TransformPoint(dir * 5);
                transform.DOMove(targetPosition,0.5f);
            }
        }

        private void ResetPosition()
        {
            Debug.Log("ResetPosition");
            transform.DOMove(_initialPosition,0.5f);
        }

        private void OnDestroy()
        {
            EventsManager.PlayerStartMoving -= ResetPosition;
            EventsManager.PlayerStopMoving -= AttackPlayer;
        }
    }
}
