using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        private Camera _camera;
        [SerializeField] private PlayerMotor motor;
        [SerializeField] private LayerMask movementMask;

        private void Start()
        {
            _camera = Camera.main;
        }
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
             
                if (Physics.Raycast(ray,out hit,1000,movementMask))
                {
                    motor.MoveToPoint(hit.point);
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                motor.Stop();
            }
        }
    }
}
