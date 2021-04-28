using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxspawner : MonoBehaviour
{
    public GameObject prefab; 
    public int xRange = 20, zRange = 20;
    public Transform player;
    bool canSpawn = true;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Wait());
    }
    void SpawnBox() {
        GameObject box = Instantiate(prefab, this.transform.position, this.transform.rotation); 
        box.transform.Translate(Random.Range(-xRange, xRange), 5, Random.Range(-zRange, zRange));
        box.AddComponent<Rigidbody>();
        box.GetComponent<MoveToPlayer>().Player = player;
    }
    
    IEnumerator Wait() {
        yield return new WaitForSeconds(5);
        SpawnBox(); 
    }
}
