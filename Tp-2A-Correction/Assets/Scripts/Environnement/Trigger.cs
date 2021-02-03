using System;
using UnityEngine;

namespace Environnement
{
    enum TriggerAction
    {
        APPEAR,
        DISAPPEAR,
    }
    
    public class Trigger : MonoBehaviour
    {
        [SerializeField] private GameObject m_ObjectToTrigger;
        [SerializeField] private TriggerAction m_TriggerAction;
        

        private void OnTriggerEnter2D(Collider2D other)
        {
            // Maintenant on fait apparaitre ou disparaitre l'obstacle en fonction de l'enum
            switch (m_TriggerAction)
            {
                case TriggerAction.APPEAR:
                    m_ObjectToTrigger.SetActive(true);
                    break;
                case TriggerAction.DISAPPEAR:
                    m_ObjectToTrigger.SetActive(false);
                    break;
            }
        }
    }
}