using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3();
    public Quaternion rotation = new Quaternion();
    //public Transform cameraTransform;
    
    
    public void Update()
    {
        gameObject.transform.position = player.position + offset;
        transform.rotation = rotation;


    }
    
    
}
