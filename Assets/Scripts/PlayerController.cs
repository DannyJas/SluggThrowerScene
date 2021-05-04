using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    public int coins = 0; 

    [SerializeField] 
    AudioClip dooropen; 

    AudioSource aud; 

    public GameObject Gun;

    // Start is called before the first frame update
    void Start()
    {
        aud = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame

    [SerializeField]
    Transform hand; 
    //Gun heldItem; 


    [SerializeField]
    IItem heldItem; 
    GameObject Bullet;

    bool canPickUp;

    IItem lastTouchedItem;

    void Update() {
    
    if(Input.GetButtonDown("Fire1")) {
        Debug.Log("Is fire one working???");
        if(heldItem != null) {
            heldItem.Use(); 

            Debug.Log("ERROR HERE?" + heldItem);  
        } else {
            Debug.Log("we arent holding anyhting."); 
        }
    }
    if(Input.GetKeyDown(KeyCode.Q)) {
        if(heldItem != null) {
            heldItem.Drop(); 
            heldItem = null; 
        } else {
            Debug.Log("We aren't holding anything."); 
        }
    }
    if (Input.GetKeyDown(KeyCode.E) && canPickUp == true) {

            heldItem = lastTouchedItem;
            heldItem.Pickup(hand);  
        }  
    }

    int totalKeys = 0; 


    // void OnCollisionEnter (Collision other) {
    //     if (other.gameObject.CompareTag ("Item")) {
    //         Gun = other.gameObject;
    //         if (Input.GetKeyDown(KeyCode.E)) { 
    //             if (heldItem != null) {
    //                 return;
    //             } 
    //         heldItem = Gun.GetComponent<IItem>();
    //         heldItem.Pickup(hand);
    // }
    //     }
    // }

    void OnTriggerEnter(Collider other) {
        
    Debug.Log("I have hit" + other.gameObject.name);
        if(other.gameObject.CompareTag("Item")) {
            if(heldItem == null) {
                canPickUp = true;
                lastTouchedItem = other.GetComponent<IItem>();
            } 
        }
        if (other.gameObject.CompareTag("floor")) {
            other.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        if(other.gameObject.CompareTag("coin")) {
            Debug.Log("Coins collected: "+ coins);
            Destroy(other.gameObject);
            coins +=1;
            
            // Destroy the coin
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Door")) {
            if(totalKeys > 0 ) {
                totalKeys -= 1; 
                Destroy(other.gameObject); 
                aud.PlayOneShot(dooropen);
            } else {
                Debug.Log("LOL go find the key to open the door bro!");
            }
        }

        if (other.gameObject.CompareTag("Key")) {
            totalKeys += 1; 
            Destroy(other.gameObject);


        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        if (other.gameObject.CompareTag("Item")) {
          canPickUp =false;
          lastTouchedItem = null;  
        }
    }
}
