using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class CivilMove : MonoBehaviour
{
    public Transform positionCivil;
    public Transform[] positionToGo;
    private float speed = 5f;
    private Vector3 _vector3 = new Vector3(0, 0, 1);
    private Rigidbody rb;
    private NavMeshAgent _civil;
    public Timer _timer;
    
    public GameObject popUpMessage;
    public string messageLog;

    
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        _civil = GetComponent<NavMeshAgent>();
        //_civil.SetDestination(positionToGo[0].position);
    }

    
    public void Update()
    {
      
        //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -5f,5f));
        
        /*transform.Translate(_vector3*speed*Time.deltaTime,positionToGo[0]);
        
        if (positionCivil.position.z >= 5)
        {
            _vector3 = new Vector3(0, 0, -1);
            transform.Translate(_vector3 * speed * Time.deltaTime);
        }

        if (positionCivil.position.z <= -5)
        {
            _vector3 = new Vector3(0, 0, 1);
            transform.Translate(_vector3 * speed * Time.deltaTime);
        }*/


        //transform.Translate(Vector3.Normalize(positionToGo[0].position - positionCivil.position)/20f);

        

       /* _civil.SetDestination(positionToGo[0].position);
        
        if (positionCivil.position == positionToGo[0].position)
        {
            _civil.SetDestination(positionToGo[1].position);
        }
        if (positionCivil.position == positionToGo[1].position)
        {
            _civil.SetDestination(positionToGo[2].position);
        }
        if (positionCivil.position == positionToGo[2].position)
        {
            _civil.SetDestination(positionToGo[3].position);
        }
        if (positionCivil.position == positionToGo[3].position)
        {
            _civil.SetDestination(positionToGo[0].position);
        }*/

      
        

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("a"))
        {
            _civil.SetDestination(positionToGo[1].position);
        }
        if (other.gameObject.CompareTag("b"))
        {
            _civil.SetDestination(positionToGo[2].position);
        }
        if (other.gameObject.CompareTag("c"))
        {
            _civil.SetDestination(positionToGo[3].position);
        }
        if (other.gameObject.CompareTag("d"))
        {
            _civil.SetDestination(positionToGo[0].position);
        }
        
        
        
        if (other.gameObject.CompareTag("Player"))
        {
           // Debug.Log("contact");
            _timer.timeRemaining -= 10;
            
            popUpMessage.SetActive(true);
            popUpMessage.GetComponent<Text>().text = messageLog;
            StartCoroutine(MessageFade());
            popUpMessage.SetActive(true);
            
            
        }
        
        IEnumerator MessageFade()
        {
            yield return new WaitForSeconds(1);
            popUpMessage.gameObject.SetActive(false);
            Destroy(gameObject);
        }
        
    }
}