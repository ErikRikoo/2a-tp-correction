using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "CharacterConfig", menuName = "Game/Config/Character", order = 0)]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private float m_PlayerSpeed = 1f;
        public float PlayerSpeed => m_PlayerSpeed;
        
        [SerializeField] private float m_JumpStrength = 100f;
        public float JumpStrength => m_JumpStrength;
        
        [SerializeField] private int m_MaxJumpCount = 2;
        public int MaxJumpCount => m_MaxJumpCount;
    }
}