using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrenade : MonoBehaviour
{

    private Rigidbody rb;
    public float grenadeSpeed = 0;
    public float jump = 50;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        GrenadeMoves();
    }


    public void GrenadeMoves()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            rb.AddForce(0,0,grenadeSpeed);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0,0,-grenadeSpeed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(grenadeSpeed,0,0);
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(-grenadeSpeed,0,0);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("je saute");
            rb.AddForce(0,5*jump,0);
        }
        
    }
}
