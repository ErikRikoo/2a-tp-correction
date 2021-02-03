using PlayerInput;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private JumpConfig m_Config;
        
        [SerializeField] private IInput m_Input;

        private int m_JumpCount;
        
        private Rigidbody2D m_RigidBody;

        private void Awake()
        {
            m_RigidBody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            Jump();
        }
        
        private void Jump()
        {
            if (m_Input.ShouldJump() && m_JumpCount < m_Config.MaxJumpCount)
            {
                // On réinitialise la vitesse du rigidbody afin de s'assurer qu'un saut ait toujours le même comportement
                m_RigidBody.velocity = Vector2.zero;
                m_RigidBody.AddForce(Vector3.up * m_Config.JumpStrength);
                ++m_JumpCount;
            }
        }

        // Appelée dès que notre objet entre en collision avec un autre
        // On s'en sert pour réinitialiser le nombre de sauts si nécessaire
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (IsGround(other.GetContact(0).normal))
            {
                m_JumpCount = 0;
            }
        }

        private bool IsGround(Vector2 _faceNormal)
        {
            return Vector2.Dot(_faceNormal, Vector2.up) > 0;
        }
    }
}