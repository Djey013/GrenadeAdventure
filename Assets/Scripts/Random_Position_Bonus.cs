using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Random_Position_Bonus : MonoBehaviour
{
 public GameObject[] position_Bonus_Timer;
 private int index1 = 0;
 private int index2 = 0;
 private int index3 = 0;


 public void Start()
 {
     index1 = Random.Range(0, 6);
     index2 = Random.Range(7, 13);
     index3 = Random.Range(14, 20);
     
     position_Bonus_Timer[index1].SetActive(true);
     position_Bonus_Timer[index2].SetActive(true);
     position_Bonus_Timer[index3].SetActive(true);
 }
}
