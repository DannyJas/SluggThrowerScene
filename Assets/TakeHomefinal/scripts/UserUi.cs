using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UserUi : MonoBehaviour
{
    PlayerHealth playerHealth; 
    [SerializeField] 
    TMP_Text HealthDisplay;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("FPS_CustomController (1)").GetComponent<PlayerHealth>();
       HealthDisplay.text = "Health: " + playerHealth.health;  
    }

    // Update is called once per frame
    void Update()
    {
         HealthDisplay.text = "Health: " + playerHealth.health;  
    }
}
