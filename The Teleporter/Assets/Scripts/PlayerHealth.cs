using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 4;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    
    public void TakeDamage(int amount){
        //GetComponent<AudioSource>().Play();
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

        public void AddHealth(int amount){
        
        if(health < 4){
            health += amount;
           
            
        }
    }

    void Die()
    {
        // Load the death menu scene
        SceneManager.LoadScene("DeathMenu");

        // Destroy the player object
        Destroy(gameObject);
    }

}
