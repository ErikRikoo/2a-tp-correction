using System;
using UnityEngine;

namespace Environnement
{
    enum TriggerAction
    {
        APPEAR,
        DISAPPEAR,
        MOVE_TOP, // On voit bien qu'à chaque nouvelle fonctionnalité on doit changer l'enum
    }
    
    public class Trigger : MonoBehaviour
    {
        [SerializeField] private GameObject m_ObjectToTrigger;
        [SerializeField] private TriggerAction m_TriggerAction;
        
        // On rajoute cette valeur qui est alors inutile si on ne veut pas bouger l'objet 
        [SerializeField] private float m_TopMovementOffset = 2f;
        

        private void OnTriggerEnter2D(Collider2D other)
        {
            // Mais on doit aussi changer l'implémentation
            // On voit bien ici qu'il y a un problème
            // Ce n'est absolument pas modulable
            // Ce n'est pas designer friendly
            // Ca viole le principe d'Open-Closed de SOLID
            // Et on pourrait appliquer le principe d'inversion de dépendance (SOLID)
            switch (m_TriggerAction)
            {
                case TriggerAction.APPEAR:
                    m_ObjectToTrigger.SetActive(true);
                    break;
                case TriggerAction.DISAPPEAR:
                    m_ObjectToTrigger.SetActive(false);
                    break;
                case TriggerAction.MOVE_TOP:
                    m_ObjectToTrigger.transform.position += Vector3.up * m_TopMovementOffset;
                    break;
            }
        }
    }
}