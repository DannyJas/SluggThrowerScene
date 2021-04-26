using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Don't forget this lol

[RequireComponent(typeof(NavMeshAgent))]
public class MoveTo : MonoBehaviour
{

    NavMeshAgent agent; 

    public Transform goal; 

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.position;
    }
}
