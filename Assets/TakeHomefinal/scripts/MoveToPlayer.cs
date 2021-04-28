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
}
