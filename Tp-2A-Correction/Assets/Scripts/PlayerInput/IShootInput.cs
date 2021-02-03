using UnityEngine;

namespace PlayerInput
{
    public abstract class IShootInput : MonoBehaviour
    {
        public abstract bool ShouldShoot();
    }
}