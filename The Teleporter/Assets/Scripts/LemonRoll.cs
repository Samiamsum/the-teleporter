using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonRoll : MonoBehaviour
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
        if(Vector2.Distance(transform.position, playerPos.position) > 2.5f){
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }

        // Check the relative position of the player compared to the enemy
        if (playerPos.position.x > transform.position.x)
        {
            // Player is to the right of the enemy, flip the sprite to face right
            spriteRenderer.flipX = false;
        }
        else
        {
            // Player is to the left of the enemy, flip the sprite to face left
            spriteRenderer.flipX = true;
        }

    }

    void FixedUpdate(){
        //Rotation();
    }

    void Rotation(){
        Vector2 direction = (playerPos.gameObject.GetComponent<Rigidbody2D>().position - rb.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90;
        rb.rotation = angle;
    }
}
