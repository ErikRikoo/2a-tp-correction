using System;
using Player;
using UnityEngine;

namespace Ennemy
{
    public class TargetPointingEnnemy : MonoBehaviour
    {
        [SerializeField] private GameObjectVariable m_GameObjectVariable;
        
        [SerializeField] private Transform m_BulletSpawningPlace;

        private float m_SpawningPlaceMagnitudeFromOject;
        
        private void Awake()
        {
            // On calcule la distance à laquelle se trouve le spawning place
            m_SpawningPlaceMagnitudeFromOject = (m_BulletSpawningPlace.position - transform.position).magnitude;
        }

        private void Update()
        {
            // Ici le cast implicit vers Transform, nous permet de passer directement notre SO dans la fonction
            MakeSpawningPlaceFacePlayer(m_GameObjectVariable);
        }

        private void MakeSpawningPlaceFacePlayer(Transform mainPlayerVariable)
        {
            // On calcule l'angle avec l'axe des x
            Vector3 delta = (mainPlayerVariable.position - m_BulletSpawningPlace.position).normalized;
            float angle = Mathf.Atan2(delta.y, delta.x);
            
            // On place le transform au bon endroit, en fonction de l'angle
            m_BulletSpawningPlace.localPosition = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0f) 
                                                  * m_SpawningPlaceMagnitudeFromOject;
            
            // On change la rotation du transform, afin que les balles aient la bonne
            Vector3 eulerAngles = m_BulletSpawningPlace.eulerAngles;
            eulerAngles.z = angle  * Mathf.Rad2Deg;
            m_BulletSpawningPlace.eulerAngles = eulerAngles;

        }
    }
}