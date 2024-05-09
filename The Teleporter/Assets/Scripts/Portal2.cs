using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal2 : MonoBehaviour
{

    //Portal2 for level2
    // teleports player to level3

    //WHEN ALL ENEMIES IN LEVEL DIE (WITH ENEMY TAG)
    //SPWAN THE PORTAL
    //PORTAL IS ENTRY TO NEXT LEVEL

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
             //switch to next level/scene
             SceneManager.LoadScene("Level3");
         }
    }
}