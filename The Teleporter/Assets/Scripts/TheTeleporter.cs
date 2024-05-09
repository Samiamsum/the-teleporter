using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //The teleporter shoots towards player and teleports around

public class TheTeleporter : MonoBehaviour
{

    public float minX = -5f; // Minimum X position
    public float maxX = 5f; // Maximum X position
    public float minY = -5f; // Minimum Y position
    public float maxY = 5f; // Maximum Y position
    public float teleportInterval = 5f; // Time interval between teleportations
    protected float timer = 0;
    private Transform playerPos;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
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
    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if(timer > 4.5f){
            timer = 0;

            Teleport();
        }
        
        
    }

    public void Teleport(){
        // Generate random X and Y positions within the specified boundaries
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Set the position of the enemy to the randomly generated position
        transform.position = new Vector2(randomX, randomY);
       
    }

    IEnumerator Shoot(){
    
        Instantiate(bullet, bulletPos.position, transform.rotation);
        yield return new WaitForSeconds(.1f);
        Instantiate(bullet, bulletPos.position, transform.rotation);
        yield return new WaitForSeconds(.1f);
        Instantiate(bullet, bulletPos.position, transform.rotation);

        yield return new WaitForSeconds(4.5f);
        StartCoroutine(Shoot());
    }




}
