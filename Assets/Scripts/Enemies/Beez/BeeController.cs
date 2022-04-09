using System.Collections;
using DG.Tweening;
using UnityEngine;
using Weapons;

namespace Enemies.Beez
{
    public class BeeController : EnemyController
    { 
        private void Update()
        {
            transform.LookAt(Target.transform);
        }
        protected override void AttackPlayer()
        {
            var targetPosition = Target.transform.position;
            var distance = Vector3.Distance (transform.position,targetPosition );
            
            if (distance < Weapon.AttackRange)
            {
                AttackCoroutine = StartCoroutine(WaitToAttack(targetPosition));
                InvokeRepeating("GenerateWeapon",2,0.5f);
            }
        }
        protected override void ResetPosition()
        {
            base.ResetPosition();
            CancelInvoke();
            if (AttackCoroutine != null)
            {
                StopCoroutine(AttackCoroutine);
            }
        }
        private IEnumerator WaitToAttack(Vector3 targetPosition)
        {
            yield return new WaitForSeconds(0.8f);
            Vector3 dir = (this.transform.position - targetPosition).normalized;
            targetPosition=  Target.transform.TransformPoint(dir * 5);
            transform.DOMove(targetPosition,0.5f);
        }

        private void GenerateWeapon()
        {
            var weapon = Instantiate(view.Weapon,view.weaponSpawnPoint).GetComponent<IWeapon>();
            weapon.CanAttack = true;
            weapon.Attack();
        }
    }
}
