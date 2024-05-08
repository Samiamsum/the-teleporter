using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //MintSpawn enemy should slowly walk towards player, damage on collision.
    //should be a two shot with the starter weapon, one shot with everything else

public class MintSpawn : MonoBehaviour
{
    private Transform playerPos;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    public float speed = .3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if distance between player and enemy is ~
        if(Vector2.Distance(transform.position, playerPos.position) > 0.1f){
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }

        //find position of the player compared to the enemy
        if (playerPos.position.x > transform.position.x)
        {
            // if player is to the right of the enemy, flip sprite to the right
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }

    }

    void FixedUpdate(){
        
    }


}

