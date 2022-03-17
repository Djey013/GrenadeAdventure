using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public float timeUp = 0f;
    public Text TimerBoard;

    private void Start()
    {
        rotation_bonusTimer.OnChronoChange += UpdateTimer;
    }

    void Update()
    {
        Clock();
    }

    public void Clock()
    {
        timeRemaining -= 1 * Time.deltaTime;
        TimerBoard.text = timeRemaining.ToString("0");

        if (timeRemaining < timeUp)
        {
            timeRemaining = 0f;
        }

        if (timeRemaining < 30)
        {
            TimerBoard.color = Color.yellow;
        }
        
        if (timeRemaining < 10)
        {
            TimerBoard.color = Color.red;
        }
        
    }

    void UpdateTimer()
    {
        timeRemaining += 5;
    }
}
