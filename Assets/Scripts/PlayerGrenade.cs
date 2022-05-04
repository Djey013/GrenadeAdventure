using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrenade : MonoBehaviour
{

    private Rigidbody rb;
    public float grenadeSpeed = 0;
    public float jump = 50;
    public bool canJump = false;

    private void OnEnable()
    {
        EventManager.MoveUp += GrenadeUp;
        EventManager.MoveDown += GrenadeDown;
        EventManager.MoveRight += GrenadeRight;
        EventManager.MoveLeft += GrenadeLeft;
        EventManager.Jump += GrenadeJump;
           
    }

    private void OnDisable()
    {
        EventManager.MoveUp -= GrenadeUp;
        EventManager.MoveDown -= GrenadeDown;
        EventManager.MoveRight -= GrenadeRight;
        EventManager.MoveLeft -= GrenadeLeft;
        EventManager.Jump -= GrenadeJump;
        
    }


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    public void GrenadeUp()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            rb.AddForce(0,0,grenadeSpeed * Time.deltaTime);
        }
    }
    
    public void GrenadeDown()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0,0,-grenadeSpeed * Time.deltaTime);
        }
    }
    
    public void GrenadeRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(grenadeSpeed * Time.deltaTime,0,0);
        }
    }
    
    public void GrenadeLeft()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(-grenadeSpeed * Time.deltaTime,0,0);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
        
    }
    
    public void GrenadeJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0,5*jump,0);
            canJump = false;
        }
    }

    
}
