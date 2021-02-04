using System;
using UnityEngine;

namespace Player
{
    public class MainPlayerStore : MonoBehaviour
    {
        [SerializeField] private GameObjectVariable Storage;

        private void Awake()
        {
            // On l'utilise sur le joueur afin de le stocker dans la variable
            Storage.Value = gameObject;
        }
    }
}