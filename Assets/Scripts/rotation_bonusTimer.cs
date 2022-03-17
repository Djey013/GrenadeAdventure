using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//script "publisher"

public class rotation_bonusTimer : MonoBehaviour
{
    public delegate void OnChronoChanger();
    public static event OnChronoChanger OnChronoChange;
    
    public Timer _timer;
    public GameObject popUpMessage;
    public string messageLog;
    
    private float _speedRotate = 50;
    private Vector3 _rotation = new Vector3(0,1,0);

     public void Update()
     {
        gameObject.transform.Rotate(_rotation*_speedRotate*Time.deltaTime);
     }

     private void OnCollisionEnter(Collision other)
     {
         popUpMessage.SetActive(true);
         popUpMessage.GetComponent<Text>().text = messageLog;
         
         OnChronoChange?.Invoke();   //invoke la fonction UpdateTimer du script "Timer" s'il y a une collision
         
         StartCoroutine(MessageFade());
         
     }
     
     private IEnumerator MessageFade()
     {
         yield return new WaitForSeconds(1);
         popUpMessage.gameObject.SetActive(false);
         Destroy(gameObject);
     }
     
 
 
 
}
