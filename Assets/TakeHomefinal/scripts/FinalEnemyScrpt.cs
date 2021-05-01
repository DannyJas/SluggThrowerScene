using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemyScrpt : MonoBehaviour
{
    public int enemeyHealth;
    public static int enenmydamage;
    public static int enemieskilled = 0;
    public int RandomCase;
    int bulletDamage;
    
    Renderer rend;
    Color OrginalColor;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        OrginalColor = rend.material.color;
        bulletDamage = bullet.bulletDamage;
        if (enemieskilled < 2 ) {
            enenmydamage = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(enemeyHealth <= 0) {
            Destroy(this.gameObject);
            enemieskilled++;
            //RandomCase = Random.Range(0, 4);
            //Debug.Log(RandomCase);
        }
        if  (enemieskilled >= 2) {
            enenmydamage = 10;
        }

    }

    void OnCollisionEnter(Collision col) {
        switch (RandomCase) {
            case 0 : 
                if(col.gameObject.CompareTag("Air")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red; 
                    StartCoroutine(ColorBack());
                }
                if(col.gameObject.CompareTag("Water")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red;
                    StartCoroutine(ColorBack());
                }
            break; 
            case 1 : 
                if(col.gameObject.CompareTag("Earth")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red; 
                    StartCoroutine(ColorBack());
                }
                if(col.gameObject.CompareTag("Fire")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red;
                    StartCoroutine(ColorBack());
                }
            break;
            case 2: 
                if(col.gameObject.CompareTag("Air")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red; 
                    StartCoroutine(ColorBack());
                }
                if(col.gameObject.CompareTag("Earth")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red;
                    StartCoroutine(ColorBack());
                }
            break;
            case 3: 
                if(col.gameObject.CompareTag("Fire")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red; 
                    StartCoroutine(ColorBack());
                }
                if(col.gameObject.CompareTag("Water")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red;
                    StartCoroutine(ColorBack());
                }
            break;
            case 4:
                if(col.gameObject.CompareTag("Earth")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red; 
                    StartCoroutine(ColorBack());
                }
                if(col.gameObject.CompareTag("Water")) {
                    Debug.Log("The bullet is hitting the enemy");
                    enemeyHealth -= bulletDamage;
                    rend.material.color = Color.red;
                    StartCoroutine(ColorBack());
                }            
            break;

        }
    }

    IEnumerator ColorBack() {
        yield return new WaitForSeconds (1);
        rend.material.color = OrginalColor;
    }
    
}
