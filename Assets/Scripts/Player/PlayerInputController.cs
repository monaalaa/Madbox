using Controllers;
using UnityEngine;

namespace Player
{
    public class PlayerInputController : IInputController
    {
        public bool StartMove()
        {
            return Input.GetMouseButtonDown(0);
        }
        public bool Moving()
        {
            return Input.GetMouseButton(0);
        }
        public bool EndMove()
        {
            return Input.GetMouseButtonUp(0);
        }
        public bool Attack()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}
