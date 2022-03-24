using Managers;
using Player.misc;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        private int _rayCastDistance = 1000;
        private Camera _camera;
        [SerializeField] private PlayerMotor motor;
        [SerializeField] private LayerMask movementMask;

        private void Start()
        {
            _camera = Camera.main;
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
        }
    }
}
