using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "WeaponConfig", menuName = "Game/Config/Weapon", order = 0)]
    public class WeaponConfig : ScriptableObject
    {
        [SerializeField] private BulletController m_BulletToSpawn;
        public BulletController BulletToSpawn => m_BulletToSpawn;
        
        [SerializeField] private float m_ShootingDelay;
        public float ShootingDelay => m_ShootingDelay;
        
    }
}