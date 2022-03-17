using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemyAI : MonoBehaviour
{

    private NavMeshAgent navMesh;
    public GameObject playerGrenade;

    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navMesh.SetDestination(playerGrenade.transform.position);
    }
}
