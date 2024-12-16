using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class thugwalk : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform ova;
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit laserImpactReport = new RaycastHit();
            if (Physics.Raycast(laser, out laserImpactReport)){
        if (Input.GetMouseButtonDown(0)){
            agent.SetDestination(laserImpactReport.point);
    }
}
     } 
     
     
     
     }
