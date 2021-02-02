using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform m_Target;
    [SerializeField] private float m_MovementSpeed;
    

    private float m_OriginalZPosition;

    private void Awake()
    {
        m_OriginalZPosition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goal = m_Target.position;
        
        // On fait une interpolation linéaire entre la position actuelle et l'objectif
        // On ajoute Unclamped afin d'éviter le clamp que fait le Lerp si on lui passe un t en dehors de [0, 1]
        Vector3 nextPosition = Vector3.LerpUnclamped(transform.position, goal, m_MovementSpeed);
        nextPosition.z = m_OriginalZPosition;

        // On l'assigne à la position de la caméra
        transform.position = nextPosition;
    }
}
