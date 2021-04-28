using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    void OnCollisionEnter(Collision col) {
           Destroy(this.gameObject);
        }
}
