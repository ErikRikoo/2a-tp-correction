using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "MainPlayerVariable", menuName = "Game/Variables/Main Player", order = 0)]
    public class MainPlayerVariable : ScriptableObject
    {
        [HideInInspector]
        public GameObject Value;
        
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