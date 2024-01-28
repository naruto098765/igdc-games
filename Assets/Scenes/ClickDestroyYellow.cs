using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ClickDestroyYellow : MonoBehaviour, IPointerClickHandler
{
   
    public AudioSource whislte_Baloon;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Update the score text
       

        whislte_Baloon.Play();

        // Destroy the GameObject when clicked
        Destroy(gameObject);
    }

   
}
