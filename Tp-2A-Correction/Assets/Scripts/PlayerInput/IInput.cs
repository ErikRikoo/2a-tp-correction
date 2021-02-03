using UnityEngine;

namespace PlayerInput
{
    // On utilise une "interface" pour représenter nos entrées utilisateurs
    // On le fait sous forme de MonoBehaviour abstrait car les interfaces ne sont pas supportés comme élément serializable
    // Pour Unity
    public abstract class IInput : MonoBehaviour
    {
        public abstract float GetHorizontalAxis();

        public abstract bool ShouldJump();
    }
}