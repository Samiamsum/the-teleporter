using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPowerUp : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float delayBeforeDestroy = .09f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
         if(other.CompareTag("Player"))
         {
    //        // Destroy(other.gameObject);
    //        // hurt player
            GetComponent<AudioSource>().Play();
             playerHealth.AddHealth(1);
    //         //destroy the bullet itself
              //Destroy(gameObject);
               Destroy(gameObject, delayBeforeDestroy);
         }
    }
}
