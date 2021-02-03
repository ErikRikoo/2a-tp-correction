using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "JumpConfig", menuName = "Game/Config/Jump", order = 0)]
    public class JumpConfig : ScriptableObject
    {
        [SerializeField] private float m_JumpStrength = 100f;
        public float JumpStrength => m_JumpStrength;
        
        [SerializeField] private int m_MaxJumpCount = 2;
        public int MaxJumpCount => m_MaxJumpCount;
    }
}