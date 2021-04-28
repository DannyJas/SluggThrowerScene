using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemyScrpt4 : MonoBehaviour
{

    [SerializeField]
    int bulletDamage;

    [SerializeField]
    int enemeyHealth;

    Renderer rend;
    Color OrginalColor;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        OrginalColor = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemeyHealth == 0) {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision col) {
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
    }

    IEnumerator ColorBack() {
        yield return new WaitForSeconds (1);
        rend.material.color = OrginalColor;
    }
    
}

