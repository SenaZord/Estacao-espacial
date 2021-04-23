using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //array de agents
    GameObject[] agents;
    void Start()
    {
        //fazendo identificação de agents por tag "ai"
        agents = GameObject.FindGameObjectsWithTag("ai");
    }


    void Update()
    {
        //configurando botão 0 do mouse
        if (Input.GetMouseButtonDown(0))
        {
            //gerando raycast
            RaycastHit hit;

            //configurando raycast para posição conforme click do mouse
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
