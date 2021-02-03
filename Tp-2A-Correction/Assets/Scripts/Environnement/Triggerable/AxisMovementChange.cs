using UnityEngine;

namespace Environnement
{
    public class AxisMovementChange : ITriggerable
    {
        [SerializeField] private Vector3 m_AxisMovement = Vector2.up;
        [SerializeField] private float m_MovementMagnitude = 2f;
        
        public override void Trigger()
        {
            transform.position += m_AxisMovement * m_MovementMagnitude;
        }
    }
}