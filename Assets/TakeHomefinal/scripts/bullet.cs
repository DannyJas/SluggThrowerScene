using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public static int bulletDamage = 3;


    void OnCollisionEnter(Collision col) {
           Destroy(this.gameObject);
        }
}
