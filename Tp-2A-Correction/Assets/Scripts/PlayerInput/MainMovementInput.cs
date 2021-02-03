using UnityEngine;

namespace PlayerInput
{
    public class MainMovementInput : IMovementInput
    {
        public override float GetHorizontalAxis()
        {
            return Input.GetAxis("Horizontal");
        }
    }
}