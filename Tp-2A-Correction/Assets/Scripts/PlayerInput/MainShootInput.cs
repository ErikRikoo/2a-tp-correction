using UnityEngine;

namespace PlayerInput
{
    public class MainShootInput : IShootInput
    {
        public override bool ShouldShoot()
        {
            return Input.GetKeyDown(KeyCode.C);
        }
    }
}