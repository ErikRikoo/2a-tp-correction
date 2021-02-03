using UnityEngine;

namespace PlayerInput
{
    // On utilise une "interface" pour représenter nos entrées utilisateurs en rapport au saut
    // On le fait sous forme de MonoBehaviour abstrait car les interfaces ne sont pas supportés comme élément serializable
    // Ainsi si le saut vient d'une entrée séparée du mouvement cela ne pose pas de problème
    // Le code reste court
    public abstract class IJumpInput : MonoBehaviour
    {
        public abstract bool ShouldJump();
    }
}