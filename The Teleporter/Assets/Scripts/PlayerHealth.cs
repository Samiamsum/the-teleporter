using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        health -= amount;
        if(health<= 0){
            //Destroy(gameObject);
            //character dies
            //menu appears to play again or quit
        }
    }

        public void AddHealth(int amount){
        
        if(health < 4){
            health += amount;
            //Destroy(gameObject);
            
        }
    }

}
