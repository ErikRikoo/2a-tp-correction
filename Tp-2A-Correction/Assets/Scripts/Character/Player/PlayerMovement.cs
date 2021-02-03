using PlayerInput;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Speed m_Speed;
        [SerializeField] private IInput m_Input;
        
        void Update()
        {
            Movement();
        }

        private void Movement()
        {
            // On récupère l'entrée utilisateur
            // Cela va nous retourner -1 si on appuie sur la flèche de gauche et 1 sur la flèche de droite
            float movementInput = m_Input.GetHorizontalAxis();
        
            // On multiplie par la vitesse et surtout par le temps qui s'est écoulé entre deux images (deltaTime)
            // Ainsi on évite d'avoir un mouvement qui dépend du nombre d'images par secondes
            float movement = movementInput * Time.deltaTime * m_Speed.Value;
        
            // On l'ajoute tout simplement à la position actuelle du joueur
            transform.position += new Vector3(movement, 0f, 0f); 
        }
    }
}