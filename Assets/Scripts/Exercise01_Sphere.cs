using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01_Sphere : MonoBehaviour
{

    private Exercise01 Waves;

    public GameObject spherePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Waves = FindObjectOfType<Exercise01>();
    }


    // On mouse click we destroy the enemy.
    private void OnMouseDown()
    {
        Waves.enemiesNum -= 1;
        Destroy(gameObject);
    }
}
