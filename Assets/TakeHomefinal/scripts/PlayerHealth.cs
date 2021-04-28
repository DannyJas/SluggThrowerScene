using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public int health, enenmydamage;
    // Start is called before the first frame update
    void Start()
    {
       health = 100; 
       enenmydamage = 10;
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision col) { 
        if (col.gameObject.CompareTag("Enemy")) {
            health -= enenmydamage;
        }
    }
}
