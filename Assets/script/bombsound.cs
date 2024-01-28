using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class bombsound : MonoBehaviour
{
    public AudioSource bomb_sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        // Play click sound
        bomb_sound.Play();

        // Update the panel


        // Destroy the GameObject when clicked

    }

    
}
