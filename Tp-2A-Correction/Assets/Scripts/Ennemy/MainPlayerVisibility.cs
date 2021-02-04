using System;
using Player;
using PlayerInput;
using UnityEngine;

namespace Ennemy
{
    public class MainPlayerVisibility : IShootInput
    {
        // En utilisant un SO, on peut éviter un fort couplage avec le joueur
        // De plus, la donnée existe au delà de la scène
        // Ce qui évite les bugs
        // Et améliore la modularité
        [SerializeField] private GameObjectVariable m_ObjectToDetect;

        private bool m_VisibilityState;
        
        public override bool ShouldShoot()
        {
            return m_VisibilityState;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject == m_ObjectToDetect.Value)
            {
                ChangePlayerVisibilityState(true);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject == m_ObjectToDetect.Value)
            {
                ChangePlayerVisibilityState(true);
            } 
        }
        
        private void ChangePlayerVisibilityState(bool _newState)
        {
            m_VisibilityState = _newState;
        }
    }
}