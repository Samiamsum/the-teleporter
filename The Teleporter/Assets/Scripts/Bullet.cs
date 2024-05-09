using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Called when the bullet collides with another collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            //destroy the bullet itself
            Destroy(gameObject);
        }
        else if(other.CompareTag("Environment")){
            Destroy(other.gameObject);
            //destroy the bullet itself
            Destroy(gameObject);
        }
        else if(other.CompareTag("Wall")){
            // Do not destroy wall
            // Destroy the bullet itself
            Destroy(gameObject);
        }
    }
}

