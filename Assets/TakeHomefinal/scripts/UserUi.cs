using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class UserUi : MonoBehaviour
{
    PlayerHealth playerHealth; 
     
    public TMP_Text HealthDisplay;
    public TMP_Text EnemiesKilled;

    public TMP_Text HintsAndInstruct;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("FPS_CustomController (1)").GetComponent<PlayerHealth>();
        HealthDisplay.text = "Health: " + playerHealth.health; 
        EnemiesKilled.text = FinalEnemyScrpt.enemieskilled + "/30";
    }

    // Update is called once per frame
    void Update()
    {
         HealthDisplay.text = "Health: " + playerHealth.health;
         EnemiesKilled.text = FinalEnemyScrpt.enemieskilled + "/30"; 
         if (FinalEnemyScrpt.enemieskilled == 1 ) {
             HintsAndInstruct.text = "The enemys have Random health so you need shoot some with more or less bullets also all guns have 20 bullets! More Hints will be given! Last thing if you die then you resart. GOOD LUCK!";
         } 
         if (playerHealth.health == 50) {
             HintsAndInstruct.text = "Hint: Run into the green orb to get more health! The orb is hidden in one of the rooms that the blue steps go up to!";
         } 
         if (FinalEnemyScrpt.enemieskilled == 5) {
             HintsAndInstruct.text = "  ";
         }
         if (FinalEnemyScrpt.enemieskilled == 30) {
             SceneManager.LoadScene("WinScreen");
             playerHealth.health = 100;
             FinalEnemyScrpt.enemieskilled = 0;
         }
         if (playerHealth.health > 100) {
             HintsAndInstruct.text ="YOU FOUND AS EASTER EGG!";
         }
    }
}
