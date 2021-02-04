﻿using System;
using Player;
using UnityEngine;

namespace Ennemy
{
    public class MainEnnemy : MonoBehaviour
    {
        [SerializeField] private MainPlayerVariable m_MainPlayerVariable;
        
        [SerializeField] private Transform m_BulletSpawningPlace;

        private void Update()
        {
            MakeSpawningPlaceFacePlayer(m_MainPlayerVariable);
        }

        private void MakeSpawningPlaceFacePlayer(Transform mainPlayerVariable)
        {
            
        }
    }
}