using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemyScrpt2 : MonoBehaviour
{

    [SerializeField]
    int bulletDamage;

    [SerializeField]
    int enemeyHealth;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(enemeyHealth == 0) {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.CompareTag("Earth")) {
            Debug.Log("The bullet is hitting the enemy");
            enemeyHealth -= bulletDamage;
        }
        if(col.gameObject.CompareTag("Fire")) {
            Debug.Log("The bullet is hitting the enemy");
            enemeyHealth -= bulletDamage;
        }
    }
    
}
