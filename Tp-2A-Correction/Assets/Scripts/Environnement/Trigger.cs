using System;
using UnityEngine;

namespace Environnement
{
    public class Trigger : MonoBehaviour
    {
        [SerializeField] private ITriggerable m_ObjectToTrigger;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            // Nous avons grandement simplifié le code et avons résolu les soucis que l'on pouvait avoir
            // Nous avons pour cela respecter le principe Open Closed et
            // avons appliqué le principe d'Inversion de Dépendance
            m_ObjectToTrigger.Trigger();
        }
    }
}