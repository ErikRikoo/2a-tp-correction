using System;
using UnityEngine;

namespace Environnement
{
    public class Trigger : MonoBehaviour
    {
        [SerializeField] private GameObject m_ObjectToTrigger;

        private void OnTriggerEnter2D(Collider2D other)
        {
            // Pour le moment on fait juste apparaitre un bouton
            m_ObjectToTrigger.SetActive(true);
        }
    }
}