using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    public MoveTo AIPreFab;

    public Transform goal; 
    public float interval = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAI());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnAI() {
    while(true) {
        yield return new WaitForSeconds(interval); 
        MoveTo copy = Instantiate(AIPreFab, this.transform.position, this.transform.rotation);
        copy.goal = goal;
    }
}

}
