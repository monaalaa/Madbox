using System.Collections;
using System.Threading.Tasks;
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
        private Coroutine _attackCoroutine;
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
                _attackCoroutine = StartCoroutine(WaitToAttack(targetPosition));
            }
        }

        private void ResetPosition()
        {
            if (_attackCoroutine != null)
            {
                StopCoroutine(_attackCoroutine);
            }
            transform.DOMove(_initialPosition,0.5f);
        }

        private void OnDestroy()
        {
            EventsManager.PlayerStartMoving -= ResetPosition;
            EventsManager.PlayerStopMoving -= AttackPlayer;
        }

        IEnumerator WaitToAttack(Vector3 targetPosition)
        {
            yield return new WaitForSeconds(0.8f);
            Vector3 dir = (this.transform.position - targetPosition).normalized;
            targetPosition=  _target.transform.TransformPoint(dir * 5);
            transform.DOMove(targetPosition,0.5f);
        }
    }
}
