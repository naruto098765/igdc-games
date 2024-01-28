using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UIElements;

public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> objectPrefabs; // List of object prefabs to spawn
    public GameObject textMeshProPrefab; // TextMeshPro prefab to spawn
    public float spawnInterval = 2f; // Time interval between spawns
    public RectTransform spawnArea; // Area within the canvas where objects will spawn

    private float nextSpawnTime;
    private Vector2[] spawnPoints; // Array to store predetermined spawn points
    private bool spawningEnabled = false; // Flag to enable/disable spawning

    void Start()
    {
        GameObject instantiatedObject = Instantiate(textMeshProPrefab, Vector3.zero, Quaternion.identity, transform);

        // Calculate the number of spawn points based on the width of the spawn area
        int numSpawnPoints = Mathf.FloorToInt(spawnArea.rect.width / objectPrefabs[0].GetComponent<RectTransform>().rect.width);

        // Initialize the spawn points array
        spawnPoints = new Vector2[numSpawnPoints];

        // Calculate the position of each spawn point
        float startX = spawnArea.rect.min.x + (objectPrefabs[0].GetComponent<RectTransform>().rect.width / 2f);
        float stepX = spawnArea.rect.width / numSpawnPoints;
        for (int i = 0; i < numSpawnPoints; i++)
        {
            spawnPoints[i] = new Vector2(startX + (stepX * i), transform.position.y);
        }
    }

    void Update()
    {
        // Check if spawning is enabled and it's time to spawn a new object
        if (spawningEnabled && Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnObject()
    {
        // Randomly select an object prefab from the list
        GameObject prefabToSpawn = objectPrefabs[Random.Range(0, objectPrefabs.Count)];

        // Randomly select a spawn point
        Vector2 spawnPosition = spawnPoints[Random.Range(0, spawnPoints.Length)];

        // Adjust the Y-coordinate to be at the bottom of the spawnArea
        spawnPosition.y = spawnArea.rect.min.y;

        // Instantiate object at spawn position
        GameObject newObject;

        // Check if the prefab to spawn is the TextMeshPro prefab
        if (prefabToSpawn == textMeshProPrefab && textMeshProPrefab != null)
        {
            newObject = Instantiate(textMeshProPrefab, spawnPosition, Quaternion.identity, spawnArea);
        }
        else
        {
            newObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity, spawnArea);
        }

        RectTransform newObjectRectTransform = newObject.GetComponent<RectTransform>();
        newObjectRectTransform.anchoredPosition = spawnPosition;

        // Check if the spawned object is a TextMeshPro prefab
        if (newObject.GetComponent<TextMeshProUGUI>() != null)
        {
            // Set its anchored position without modifying Y-coordinate
            newObjectRectTransform.anchoredPosition = new Vector2(spawnPosition.x, spawnPosition.y);
        }
    }


    // Method to enable spawning
    public void EnableSpawning()
    {
        spawningEnabled = true;
    }
}
