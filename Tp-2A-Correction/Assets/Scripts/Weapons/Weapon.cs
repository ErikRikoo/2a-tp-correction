using System;
using PlayerInput;
using UnityEngine;

namespace Weapons
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponConfig m_WeaponConfig;
        [SerializeField] private IShootInput m_Input;
        [SerializeField] private Transform m_BulletSpawningPlace;
        

        private float m_ShootingAvailableTime;

        private void Update()
        {
            if (m_Input.ShouldShoot() && CanShoot())
            {
                Shoot();
            }
        }

        private bool CanShoot()
        {
            return Time.time >= m_ShootingAvailableTime;
        }

        private void Shoot()
        {
            m_ShootingAvailableTime = Time.time + m_WeaponConfig.ShootingDelay;
            
            Transform transform1 = transform;
            Instantiate(m_WeaponConfig.BulletToSpawn, m_BulletSpawningPlace.position, m_BulletSpawningPlace.rotation);
        }
    }
}