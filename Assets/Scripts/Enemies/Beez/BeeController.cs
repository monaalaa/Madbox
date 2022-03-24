using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Enemies.Beez
{
    public class BeeController : EnemyController
    { 
        private void Update()
        {
            transform.LookAt(_target.transform);
        }
        protected override void AttackPlayer()
        {
            var targetPosition = _target.transform.position;
            var distance = Vector3.Distance (transform.position,targetPosition );
            
            if (distance < view.Model.AttackRange)
            {
                _attackCoroutine = StartCoroutine(WaitToAttack(targetPosition));
            }
        }
        protected override void ResetPosition()
        {
            base.ResetPosition();
            
            if (_attackCoroutine != null)
            {
                StopCoroutine(_attackCoroutine);
            }
        }
        private IEnumerator WaitToAttack(Vector3 targetPosition)
        {
            yield return new WaitForSeconds(0.8f);
            Vector3 dir = (this.transform.position - targetPosition).normalized;
            targetPosition=  _target.transform.TransformPoint(dir * 5);
            transform.DOMove(targetPosition,0.5f);
        }
    }
}
