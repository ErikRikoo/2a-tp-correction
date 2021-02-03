using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using PlayerInput;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerConfig m_Config;

    [SerializeField] private IInput m_Input;

    private int m_JumpCount;
    
    private Rigidbody2D m_RigidBody;

    private void Awake()
    {
        m_RigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
        Jump();
    }

    private void Movement()
    {
        // On récupère l'entrée utilisateur
        // Cela va nous retourner -1 si on appuie sur la flèche de gauche et 1 sur la flèche de droite
        float movementInput = m_Input.GetHorizontalAxis();
        
        // On multiplie par la vitesse et surtout par le temps qui s'est écoulé entre deux images (deltaTime)
        // Ainsi on évite d'avoir un mouvement qui dépend du nombre d'images par secondes
        float movement = movementInput * Time.deltaTime * m_Config.PlayerSpeed;
        
        // On l'ajoute tout simplement à la position actuelle du joueur
        transform.position += new Vector3(movement, 0f, 0f); 
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
