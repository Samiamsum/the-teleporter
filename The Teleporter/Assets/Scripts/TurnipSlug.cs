using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Turnip slug slowly moves towards player and shoots player
public class TurnipSlug : MonoBehaviour
{
    private Transform playerPos;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private bool isInRange = false;
    public float speed = .3f;
    public Transform bulletPos;
    public GameObject bullet;
   

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Shoot());
        
        rb = GetComponent<Rigidbody2D>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if distance between player and enemy is greater than x units
        if(Vector2.Distance(transform.position, playerPos.position) > 3.5f){
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
            isInRange = false;
            //Debug.Log(isInRange);
        }
        else{
            isInRange = true;
            //Debug.Log(isInRange);
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

    IEnumerator Shoot(){
        if(isInRange){
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
        }
        
        yield return new WaitForSeconds(.3f);
        
        StartCoroutine(Shoot());
        
    }

}
