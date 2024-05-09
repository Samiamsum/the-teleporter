using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BerryBush : MonoBehaviour
{
    // Object to spawn upon destruction
    public GameObject Heart;

    // Called when the main object is destroyed
    void OnDestroy()
    {
        if (Heart != null)
        {
            // Get the position of the main object
            Vector3 spawnPosition = transform.position;

            // Instantiate the heart object at the calculated position
            Instantiate(Heart, spawnPosition, Quaternion.identity);
        }
    }
}
