using UnityEngine;
using TMPro;

public class YouLose : MonoBehaviour
{
    public int lives = 5;// Initial lives
    public TextMeshProUGUI livesText; // Reference to the TextMeshProUGUI object displaying lives
    public GameObject gameOverPanel; // Reference to the game over panel

    void Start()
    {
        UpdateLivesText();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Baloon"))
        {
            Debug.Log("Lives decrease");
            lives--;

            // Update the lives text
            UpdateLivesText();

            // Check if lives reach 0
            if (lives <= 0)
            {
                // Open the game over panel
                if (gameOverPanel != null)
                {
                    gameOverPanel.SetActive(true);
                }
                else
                {
                    Debug.LogWarning("Game Over Panel is not assigned!");
                }
            }
        }
    }

    void UpdateLivesText()
    {
        // Update the TextMeshProUGUI object with current lives
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
        else
        {
            Debug.LogWarning("Lives TextMeshProUGUI is not assigned!");
        }
    }
}
