using TMPro;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Game_Start;
    public GameObject Game_Play;
    public TextMeshProUGUI score;

    private BalloonMovement[] balloonMovements; // Array to store all BalloonMovement scripts

    // Start is called before the first frame update
    void Start()
    {
        
        balloonMovements = FindObjectsOfType<BalloonMovement>(); // Find all BalloonMovement scripts

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Panels()
    {
        Game_Start.SetActive(false);
        Game_Play.SetActive(true);
        score.gameObject.SetActive(true);

        // Start moving all balloons upward when the button is clicked
        foreach (var balloonMovement in balloonMovements)
        {
            balloonMovement.StartMovingUpward();
        }
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
