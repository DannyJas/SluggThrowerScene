using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GiveName : MonoBehaviour
{
    [SerializeField]
    TMP_Text RandomName; 
    
    public List<string> NewNames;
    // Start is called before the first frame update
    void Start()
    {
       int randomNameNumber = Random.Range(0,29);
       string NewWeaponName = NewNames[randomNameNumber]; 
       RandomName.text = NewWeaponName; 
       this.gameObject.name = NewWeaponName;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
