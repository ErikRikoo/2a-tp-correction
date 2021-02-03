using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Speed", menuName = "Game/Config/Speed", order = 0)]
    public class Speed : ScriptableObject
    {
        [SerializeField] private float m_Speed = 1f;

        public float Value => m_Speed;
    }
}