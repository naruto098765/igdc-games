using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Riddle_one : MonoBehaviour
{
    public GameObject Done_Button;
    public TextMeshProUGUI answer;

    // Delay before showing the button and answer (in seconds)
  

    // Start is called before the first frame update
   
   

    // Update is called once per frame
    void Update()
    {
        // Increment the timer
      
            // Activate the objects
            Done_Button.SetActive(true);
            answer.gameObject.SetActive(true);
         
    }
}
