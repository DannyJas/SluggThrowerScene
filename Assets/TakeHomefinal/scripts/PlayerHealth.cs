using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int enenmydamage;
    public int health;
    
    // Start is called before the first frame update
    void Start()
    {
       health = 100; 
    }

    void Update() {
        if (health <= 0) {
            SceneManager.LoadScene("Final");
            FinalEnemyScrpt.enemieskilled = 0;
        }
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision col) { 
        enenmydamage = FinalEnemyScrpt.enenmydamage;
        if (col.gameObject.CompareTag("Enemy")) {
            health -= enenmydamage;
        }
        if (col.gameObject.CompareTag("Health")) {
            health +=10; 
        }
    }
}
