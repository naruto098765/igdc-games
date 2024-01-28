using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ClickDestroy : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI scoreText;
    public List<GameObject> panels; // List of panels to be opened

    public void OnPointerClick(PointerEventData eventData)
    {
        // Update the score text
        UpdateScore();

        // Destroy the GameObject when clicked
        Destroy(gameObject);
    }

    void UpdateScore()
    {
        // Parse the current score text to an integer
        int currentScore = int.Parse(scoreText.text);

        // Increment the score
        currentScore++;

        // Update the TextMeshProUGUI text with the new score
        scoreText.text = currentScore.ToString();

        // Check if the score reaches or exceeds a sum of 10
        if (currentScore % 10 == 0)
        {
            // Activate a random panel from the list
            int randomIndex = Random.Range(0, panels.Count);
            GameObject panelToActivate = panels[randomIndex];
            panelToActivate.SetActive(true);

            // Pause the game by setting the time scale to 0
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        // Deactivate all panels
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }

        // Resume the game by setting the time scale back to 1
        Time.timeScale = 1;
    }
}
