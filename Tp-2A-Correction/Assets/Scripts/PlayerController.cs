using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_PlayerSpeed = 1f;
    [SerializeField] private float m_JumpStrength = 100f;
    [SerializeField] private int m_MaxJumpCount = 2;

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
        float movementInput = Input.GetAxis("Horizontal");
        
        // On multiplie par la vitesse et surtout par le temps qui s'est écoulé entre deux images (deltaTime)
        // Ainsi on évite d'avoir un mouvement qui dépend du nombre d'images par secondes
        float movement = movementInput * Time.deltaTime * m_PlayerSpeed;
        
        // On l'ajoute tout simplement à la position actuelle du joueur
        transform.position += new Vector3(movement, 0f, 0f); 
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && m_JumpCount < m_MaxJumpCount)
        {
            m_RigidBody.AddForce(Vector3.up * m_JumpStrength);
            ++m_JumpCount;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        m_JumpCount = 0;
    }
}
