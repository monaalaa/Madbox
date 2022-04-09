using Attacker;
using Controllers;
using Damageables;
using Managers;
using Player.misc;
using UnityEngine;
using Weapons;

namespace Player
{
    public class PlayerController : MonoBehaviour,IDamageable,IAttacker
    {
        private IInputController _inputController;
        private int _rayCastDistance = 1000;
        private Camera _camera;
        [SerializeField] private PlayerMotor motor;
        [SerializeField] private LayerMask movementMask;
        public IWeapon Weapon { get; set; }
        public int Health { get; set; }
        private void Start()
        {
            _camera = Camera.main;
            _inputController = new PlayerInputController();
        }
        public void ApplyDamage(int damage)
        {
             Health -= damage;
            Debug.Log("Damage " + damage);
            if (Health < 0)
            {
                Health = 0;
                //Note:- Implement GameOver
            }
        }
        private void Update()
        {
            if (_inputController.StartMove())
            {
                EventsManager.PlayerStartMoving?.Invoke();
            }
            else if (_inputController.Moving())
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray,out hit,_rayCastDistance,movementMask))
                {
                    motor.MoveToPoint(hit.point);
                }
            }
            else if (_inputController.EndMove())
            {
                motor.Stop();
                EventsManager.PlayerStopMoving?.Invoke();
            }

            if (_inputController.Attack())
            {
                Weapon.Attack();
            }
        }
    }
}
