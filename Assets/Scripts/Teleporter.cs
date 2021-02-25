using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform destination;
     
     void OnTriggerEnter(Collider other) {
         other.transform.position = destination.position; 
         other.transform.Translate(Vector3.up);
     }
}
