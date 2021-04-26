using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    [SerializeField] 
    GameObject EarthBlaster, FireBlaster, AirBlaster, WaterBlaster;

    [SerializeField]
    Transform BlasterSpawnPoint; 
 

     GameObject[] Blasters = new GameObject [4]; 

     bool canSpawn = true;

 
    GameObject Blaster;

    bool canspawn;

    // Start is called before the first frame update
    void Start()
    {
        Blasters[0] = EarthBlaster; 
        Blasters[1] = FireBlaster; 
        Blasters[2] = AirBlaster;
        Blasters[3] = WaterBlaster;
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            canSpawn = true;
            if(canSpawn) {
             int RandomBlaster = Random.Range(0,4);
              Blaster = Instantiate(Blasters[RandomBlaster].gameObject, BlasterSpawnPoint.position, BlasterSpawnPoint.rotation, null);
              canSpawn = false;
            }
        }
    }
}
