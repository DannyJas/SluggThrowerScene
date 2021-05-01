using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxspawner : MonoBehaviour
{
    public int xRange = 20, zRange = 20;
    int enemycount = 0;
    public Transform player;
    public GameObject Enemy;
    void Start () {
        SpawnBox();
    }
    void Update()
    {

    }
    void SpawnBox() {
        int RandomEnemy = Random.Range(0, 4);
        int RandomHealth =Random.Range(1, 9);
        Debug.Log(RandomEnemy);
        GameObject box = Instantiate(Enemy, this.transform.position, this.transform.rotation); 
        box.GetComponent<FinalEnemyScrpt>().RandomCase = RandomEnemy;  
        box.transform.Translate(Random.Range(-xRange, xRange), 5, Random.Range(-zRange, zRange));
        box.GetComponent<MoveToPlayer>().Player = player;
        box.GetComponent<FinalEnemyScrpt>().enemeyHealth = RandomHealth;
        enemycount++;
        if (enemycount < 2) {
        StartCoroutine(FirstTwoWait()); 
        } else {
            StartCoroutine(FastSpawn());
        }
    }
    
    IEnumerator FirstTwoWait() {
        yield return new WaitForSeconds(15);
        SpawnBox(); 
    }
    IEnumerator FastSpawn() {
        yield return new WaitForSeconds(2);
        SpawnBox(); 
    }
}
