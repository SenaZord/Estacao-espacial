using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    // variavel de NavMeshAgent
    public NavMeshAgent agent;
    void Start()
    {
        //acessando component NavMeshAgent em agent
        agent = this.GetComponent<NavMeshAgent>();
    }
}
