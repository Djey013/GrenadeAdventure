using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    
    
    public float timeRemaining = 60f;
    public float timeUp = 0f;
    public Text TimerBoard;

    private void OnEnable()
    {
        rotation_bonusTimer.OnChronoChange += UpdateTimer;   //déclenchera la fonction UpdateTimer //si l'event se produit du coté du script "rotationBonusTimer"
        
    }
    
    private void OnDisable()
    {
        rotation_bonusTimer.OnChronoChange -= UpdateTimer;
        
    }
    
    
    void Update()
    {
        Clock();
        TimeZero();
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
        timeRemaining += 5; // au lieu de mettre : _timer.timeRemaining = _timer.timeRemaining + 5;
    }

    void TimeZero()
    {
        if (timeRemaining == timeUp)
        {
            SceneManager.LoadScene("Principal");
        }
        
    }
        
    
    
    
}


