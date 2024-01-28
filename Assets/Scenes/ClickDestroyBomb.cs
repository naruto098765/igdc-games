using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickDestroyBomb : MonoBehaviour, IPointerClickHandler
{
    public GameObject GameOver;
    public AudioSource bom_snd;

  

    public void OnPointerClick(PointerEventData eventData)
    {
        // Play click sound

        bom_snd.Play();
        // Update the panel
        UpdatePanel();

        // Destroy the GameObject when clicked
        Destroy(gameObject);
    }

    void UpdatePanel()
    {
        // Activate the GameOver panel
        GameOver.SetActive(true);
    }

   
}
