using Damageables;
using Managers;
using Player.misc;
using UnityEngine;
using Weapons;

namespace Player
{
    public class PlayerController : MonoBehaviour,IDamageable
    {
        private int _rayCastDistance = 1000;
        private Camera _camera;
       
        [SerializeField] private PlayerMotor motor;
        [SerializeField] private LayerMask movementMask;
        [SerializeField] private PlayerView view;
        private IWeapon _weapon;
        
        private void Start()
        {
            _camera = Camera.main;
        }
        public void ApplyDamage(int damage)
        {
            view.model.health -= damage;
            Debug.Log("Damage " + damage);
            if (view.model.health < 0)
            {
                view.model.health = 0;
                //Note:- Implement GameOver
            }
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                EventsManager.PlayerStartMoving?.Invoke();
            }
            else if (Input.GetMouseButton(0))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray,out hit,_rayCastDistance,movementMask))
                {
                    motor.MoveToPoint(hit.point);
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                motor.Stop();
                EventsManager.PlayerStopMoving?.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _weapon.Attack();
            }
        }
    }
}
