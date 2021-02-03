using UnityEngine;

namespace PlayerInput
{
    // Nous codons une basique classe qui reprend les méthodes utilisées dans la la classe PlayerController à l'origine 
    public class MainInput : IInput
    {
        public override float GetHorizontalAxis()
        {
            return Input.GetAxis("Horizontal");
        }

        public override bool ShouldJump()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}