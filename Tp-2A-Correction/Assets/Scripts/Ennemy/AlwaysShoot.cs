using PlayerInput;
using UnityEngine;

namespace Ennemy
{
    // On voit ici qu'on a utilisé l'interafce précédente pour les inputs
    // Et on l'a surchargé afin de dire que le tir est constant
    // Ainsi on conserve le même code dans weapon
    public class AlwaysShoot : IShootInput
    {
        public override bool ShouldShoot()
        {
            return true;
        }
    }
}