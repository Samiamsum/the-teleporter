using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public GameObject player;
    public float speed;
    private Rigidbody2D rb;
    public PlayerHealth playerHealth;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        float rotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rotation);
    }

    void OnTriggerEnter2D(Collider2D other){
         if(other.CompareTag("Player"))
         {
    //        // Destroy(other.gameObject);
    //        // hurt player
             playerHealth.TakeDamage(1);
    //         //destroy the bullet itself
    //        // Destroy(gameObject);
         }
    //     else if(other.CompareTag("Wall")){
    //          //destroy the bullet itself
    //          Destroy(gameObject);
    //     }
    }



    }

