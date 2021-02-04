using PlayerInput;
using UnityEngine;

namespace Ennemy
{
    public class AlwaysShoot : IShootInput
    {
        public override bool ShouldShoot()
        {
            return true;
        }
    }
}