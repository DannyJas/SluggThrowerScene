using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GiveName : MonoBehaviour
{
    [SerializeField]
    TMP_Text RandomName; 
    string [] names = new string [30];
    // Start is called before the first frame update
    void Start()
    {
       names[0] = "Bloodspiller";  
       names[1] = "Harmony";
       names[2] = "Remorse";
       names[3] = "Singed Hand Cannon";
       names[4] = "Proud Shooter";
       names[5] = "Bandit's Golden Six-Shooter";
       names[6] = "Furious Golden Hand Cannon";
       names[7] = "Last Chance";
       names[8] = "Gift Of Grieving Widows";
       names[9] = "Finality";
       names[10] = "Crusader Of Broken Dreams";
       names[11] = "Mercy";
       names[12] = "Might Of The Beast";
       names[13] = "Warbringer";
       names[14] = "Agony";
       names[15] = "Spiteful Gun";
       names[16] = "Private Six-Shooter";
       names[17] = "Stormfury Ebon Flintlock";
       names[18] = "Conqueror's Ironbark Flintlock";
       names[19] = "Queller Of The Occult";
       names[20] = "Daddy";
       names[21] = "Dominion";
       names[22] = "Contra";
       names[23] = "Ultra85";
       names[24] = "Iron man";
       names[25] = "Ex-wife";
       names[26] = "Captain";
       names[27] = "Logic";
       names[28] = "Stick";
       names[29] = "Happy";
       int randomNameNumber = Random.Range(0,29);
       string NewName = names[randomNameNumber]; 
       RandomName.text = NewName; 
       this.gameObject.name = NewName;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
