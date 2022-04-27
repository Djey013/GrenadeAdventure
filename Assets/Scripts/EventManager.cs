using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void InputAction();

    public static event InputAction MoveUp;
    public static event InputAction MoveDown;
    public static event InputAction MoveRight;
    public static event InputAction MoveLeft;
    public static event InputAction Jump;


    private void Update()
    {
        
        if (Input.GetKey(KeyCode.Z))
        {
            MoveUp?.Invoke();
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            MoveDown?.Invoke();
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight?.Invoke();
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            MoveLeft?.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump?.Invoke();
        }
        
    }
}
