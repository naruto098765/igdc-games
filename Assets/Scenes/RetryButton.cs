using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this line to import the SceneManager namespace

public class RetryButton : MonoBehaviour
{
    // Reference to the button that triggers the retry action
    public Button retryButton;

    void Start()
    {
        // Add a listener to the button click event
        retryButton.onClick.AddListener(RetryGame);
    }

    void RetryGame()
    {
        // Restart the game by reloading the current scene
        Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene.name);
    }
}
