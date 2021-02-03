using UnityEngine;

namespace Environnement
{
    public class ActiveStateChange : ITriggerable
    {
        [SerializeField] private bool m_OnTriggerActiveState;
        
        
        public override void Trigger()
        {
            gameObject.SetActive(m_OnTriggerActiveState);
        }
    }
}