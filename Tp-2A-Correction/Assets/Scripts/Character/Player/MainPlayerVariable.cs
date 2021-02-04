using UnityEngine;

namespace Player
{
    // Inutilisé pour le moment
    
    // Cette variable nous permet de stocker sous forme d'asset dans le projet quel est le joueur principal
    // Cela nous permet donc d'accéder au joueur très facilement, sans avoir un fort couplage dans notre code
    [CreateAssetMenu(fileName = "MainPlayerVariable", menuName = "Game/Variables/Main Player", order = 0)]
    public class MainPlayerVariable : ScriptableObject
    {
        [HideInInspector]
        public GameObject Value;
        
        // On ajoute des cast implicit pour les types: Transform, GameObject
        // Vous pourrez trouver plus d'informations ici:
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators
        public static implicit operator Transform(MainPlayerVariable _instance)
        {
            return _instance.Value.transform;
        }

        public static implicit operator GameObject(MainPlayerVariable _instance)
        {
            return _instance.Value;
        }
    }
}