using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IItem 
{
    
    [SerializeField] 
    Transform firePoint;
    //GameObject Bullet;

      bool canShoot = true;


    void Start() {
        if(firePoint == null) {
            firePoint = this.transform.GetChild(2); 
        }
    } 


    public void Pickup (Transform hand) {
        Debug.Log("BANKS");
        this.gameObject.transform.SetParent(hand); 
        this.transform.localPosition = Vector3.zero;
        this.transform.localRotation = Quaternion.identity; 
        this.GetComponent<Rigidbody>().isKinematic = true;  
        this.GetComponent<Collider>().enabled = false; 
    }

    public void Use () {

        if(!canShoot) return; 
        Debug.Log("<color=red>POW!</color>"); 
        GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Cube); 
        bullet.transform.localScale = Vector3.one * 0.2f;
        bullet.transform.position = firePoint.position; 
        bullet.transform.Translate(transform.forward); 
        Rigidbody rb = bullet.AddComponent<Rigidbody>(); 
        rb.AddForce(transform.forward *20, ForceMode.Impulse); 
        canShoot = false; 
        StartCoroutine(Wait());  


    }

    public void Drop() {
        Debug.Log("Dropping our item"); 
        this.gameObject.transform.SetParent(null); 
        this.transform.Translate(0,0,2); 
        this.GetComponent<Rigidbody>().isKinematic = false; 
        this.GetComponent<Rigidbody>().AddForce(Vector3.forward*10, ForceMode.Impulse); 
        this.GetComponent<Collider>().enabled = true; 

    }

        IEnumerator Wait() {
        yield return new WaitForSeconds(1);  //wait for 1 secound 
        canShoot = true; //make canswitch true again. 
    }
}
