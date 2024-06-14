using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    public List<GameObject> obstaclePrefabs; // List of obstacle prefabs
    private List<GameObject> currentObstacles; // List of instantiated obstacles

    private List<Vector3> initialPositions;
    // Start is called before the first frame update
    void Start()
    {
        currentObstacles = new List<GameObject>();
        initialPositions = new List<Vector3>();

        // Instantiate obstacles and store their initial positions
        foreach (var obstaclePrefab in obstaclePrefabs)
        {
            GameObject obstacle = Instantiate(obstaclePrefab, obstaclePrefab.transform.position, obstaclePrefab.transform.rotation);
            currentObstacles.Add(obstacle);
            initialPositions.Add(obstacle.transform.position);
        }
    }

    // Update is called once per frame
    public void ResetObstacles()
    {
        for (int i = 0; i < currentObstacles.Count; i++)
        {
            currentObstacles[i].transform.position = initialPositions[i];
            // Reset other properties if needed, e.g., rotation, scale, etc.
        }
    }

    public void DestroyAndReinstantiateObstacles()
    {
        foreach (var obstacle in currentObstacles)
        {
            Destroy(obstacle);
        }
        currentObstacles.Clear();

        foreach (var obstaclePrefab in obstaclePrefabs)
        {
            GameObject obstacle = Instantiate(obstaclePrefab, obstaclePrefab.transform.position, obstaclePrefab.transform.rotation);
            currentObstacles.Add(obstacle);
        }
    }
}
