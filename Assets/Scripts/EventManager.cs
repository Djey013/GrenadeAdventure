using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    
    public delegate void timeLoss();
    public static event timeLoss Up; 
    
    
    
}
