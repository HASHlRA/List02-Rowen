using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    // The wave that is currently playing
    public int currentWave = 1;

    // Enemy prefab and number of them
    public GameObject spherePrefab; 
    public float enemiesNum = 1;

    // Limit of the screen
    private float yLimit = 4f;
    private float xLimit = 8f;


    // Start is called before the first frame update
    void Start()
    {
        enemiesNum = 1;
    }

    // Gives random positions for the enemy between the limits
    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit), 0);
    }

    // Update is called once per frame
    void Update()
    {
        // If there's no enemies in the scene
        if (enemiesNum == 0) 
        {
            // Pass tot eh next wave
            currentWave += 1;
            
            // The number of the wave will be the same as the number of enemies spawned
            enemiesNum = currentWave; 

            // Instantiates the enemies in a random position
            for (int i = 0; i < enemiesNum; i++)
            {
                Instantiate(spherePrefab, RandomPosition(), gameObject.transform.rotation);
            }
        }
    }
}
