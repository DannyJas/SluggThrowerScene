using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] 
    int damageAmount = 2; 

    void OnCollisionEnter(Collision col) {
           Destroy(this.gameObject);
        }
}
