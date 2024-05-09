using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PortalSpawner : MonoBehaviour
{
    // Object to spawn 
    public GameObject portal;
    private bool allEnemiesGone = false;

    void Update()
    {
        // Check if all objects with the "Enemy" tag are gone
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            allEnemiesGone = true;
        }
        else
        {
            allEnemiesGone = false;
        }

        // If all enemies are gone, start spawning
        if (allEnemiesGone)
        {
                Spawn();
        }
        
    }

    // Called when enemies are gone
    void Spawn()
    {
        
            // Get the position of the main object
            Vector3 spawnPosition = transform.position;

            // Instantiate the object at the calculated position
            Instantiate(portal, spawnPosition, Quaternion.identity);
        
    }
}