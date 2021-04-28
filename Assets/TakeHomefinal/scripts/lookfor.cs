using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookfor : MonoBehaviour
{
    public GameObject player; 
    public bool canSeePlayer;

    public GameObject patroller;
    public float feildOfView = 60; 

    private RaycastHit hit;



    // Update is called once per frame
    void Update()
    {
        Vector3 rayDirection = player.transform.position - this.transform.position;
    
        float angle = Vector3.Angle(rayDirection, transform.forward);

        if (angle < feildOfView) { 
            canSeePlayer = true;
            if (Physics.Raycast(transform.position, transform.forward, out hit)) {
                if (hit.collider.CompareTag("Player")) {
                canSeePlayer = true;
            } else {
                canSeePlayer = false; 
            }
        }
        }

        if (canSeePlayer) {
            float playerpostion = Vector3.Distance(patroller.transform.position, player.transform.position);
            if (playerpostion <= 10) {
            patroller.GetComponent<Patrol>().agent.destination = player.transform.position;
            if(playerpostion >= 20) {
                canSeePlayer = false;
            }
            }
        }
        //Debug.DrawRay(this.transform.position, rayDirection, canSeePlayer ? Color.green : Color.red);
        //Debug.DrawRay(this.transform.position, transform.forward *5);
        //Debug.Log("Angle to Player; " + Vector3.Angle(this.transform.position, player.transform.position));
    }
}
