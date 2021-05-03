using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveToPlayer : MonoBehaviour
{
    public Transform Player;

    NavMeshAgent EnemyAi;
    // Start is called before the first frame update
    void Start()
    {
        EnemyAi = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAi.destination = Player.position;
    }
    void OnCollisionEnter (Collision other) {
        if (other.gameObject.CompareTag ("Player")) {
            Debug.Log("Its find the player on the move to script");
            EnemyAi.isStopped = true;
        }
    }
    void OnCollisionExit (Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            EnemyAi.isStopped = false;
        }
    }
}
