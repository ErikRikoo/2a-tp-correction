using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_PlayerSpeed = 1f;
    
    void Update()
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
}
