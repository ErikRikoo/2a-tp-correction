using System;
using Player;
using UnityEngine;

namespace Weapons
{
    public class BulletController : MonoBehaviour
    {
        [SerializeField] private Speed m_BulletSpeed;

        private void Update()
        {
            // Ici on multiplie
            Transform transform1 = transform;
            transform1.position += transform1.right * (m_BulletSpeed.Value * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(gameObject);
        }
    }
}