using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IItem 
{
    
    [SerializeField] 
    Transform firePoint;
    GameObject Bullet;

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

        GameObject FirePoint = GameObject.Find("FirePoint"); 
        //gameObject.GetComponent("FirePoint"); 
        //gameObject.transform.SetParent(GameObject Slug Thrower);  
        //gameObject.transform.GetChild(FirePoint); 
        //Transform firePoint = GameObject.Find("FirePoint").transform; 

        GameObject bullet = Instantiate(Bullet, firePoint.position, firePoint.rotation, null); 
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward *400);

        Debug.Log("<color=red>POW!<color>"); 

        StartCoroutine(Wait());
        canShoot = false;

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
