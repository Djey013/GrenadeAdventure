using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    
    public Timer _timer;
    public GameObject popUpMessage;
    public string messageLog;
    
    private void OnTriggerEnter(Collider other)
    {
        Malus();
        // _timer.timeRemaining -= 5;  Ecriture raccourcie
        
        popUpMessage.SetActive(true);
        popUpMessage.GetComponent<Text>().text = messageLog;
        StartCoroutine(MessageFade());
        popUpMessage.SetActive(true);
        

    }

    IEnumerator MessageFade()
    {
        yield return new WaitForSeconds(1);
        popUpMessage.gameObject.SetActive(false);
        
    }

    public void Malus()
    {
        _timer.timeRemaining = _timer.timeRemaining - 5;
    }
    
}
