using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class CoinManager : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Cast a ray from the mouse position
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

        // Debug raycast hit information
        if (hit.collider != null)
        {
            Debug.Log("Raycast hit: " + hit.collider.gameObject.name);
        }
        else
        {
            Debug.Log("Raycast hit nothing.");
        }

        // Check if the ray hits an object tagged as "Balloon"
        if (hit.collider != null && hit.collider.CompareTag("Baloon"))
        {
            Debug.Log("Click");
            // Increment the score
            IncrementScore();

            // Destroy the balloon object
            Destroy(hit.collider.gameObject);
        }
    }

    void IncrementScore()
    {
        score++;
        // Check if the scoreText field is assigned
        if (scoreText != null)
        {
            // Update the TextMeshPro text with the new score
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogWarning("scoreText is null.");
        }
    }
}
