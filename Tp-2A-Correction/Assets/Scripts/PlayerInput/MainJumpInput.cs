using UnityEngine;

namespace PlayerInput
{
    public class MainJumpInput : IJumpInput
    {
        public override bool ShouldJump()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}