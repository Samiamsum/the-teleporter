using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //LemonRoll enemy stays in place, shoots fast bullets towards player

public class LemonRoll : MonoBehaviour
{

    private Transform playerPos;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
   // private bool isInRange = false;
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
        


        if (playerPos.position.x > transform.position.x)
        {
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
    
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    
        
        yield return new WaitForSeconds(.3f);
        StartCoroutine(Shoot());
    }

}
