using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{ 
    RaycastHit Hit;
    public GameObject badGuy;
    public Transform cubeDetector;
    public Vector3 direction = new Vector3(1,0,0);
    public float detectionDistance = 0f;


    public void Update()
    {
        RayDetection();
    }

    public void RayDetection()
    {
        Debug.DrawRay(cubeDetector.position, direction.normalized * detectionDistance, Color.red);
        if (Physics.Raycast(cubeDetector.position, direction.normalized, out Hit, detectionDistance))
        {
            if (Hit.collider.gameObject.GetComponent<PlayerGrenade>() != null)
            {
                badGuy.SetActive(true);
            }
        }
    }



}
