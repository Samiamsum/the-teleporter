using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    [SerializeField] private AnimationStateChanger asc;
    SpriteRenderer spriteRenderer;
    public Weapon currentWeapon; //
    public Transform weaponTransform;
    public Transform firePoint;
    private float nextTimeOfFire = 0;
    Vector2 moveDirection;
    Vector2 mousePosition;
    private bool hit = true;
    [SerializeField] private int health = 4;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {


        currentWeapon.UpdateWeaponRotation(weaponTransform);
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if(Input.GetMouseButtonDown(0))
        {
            if(Time.time >= nextTimeOfFire) //
            {
                currentWeapon.Fire(firePoint);
                nextTimeOfFire = Time.time + 1 / currentWeapon.fireRate;
            }
            
        }

        moveDirection = new Vector2(moveX, moveY).normalized;

        if(moveX<0){
                spriteRenderer.flipX = true;
                
            }
            else if(moveX>0){
                spriteRenderer.flipX = false;
            }

        //setting animation
        if(moveDirection != Vector2.zero){
            asc.changeAnimationState("Walk");
        }
        else{
            asc.changeAnimationState("Idle");
        }


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }   


    IEnumerator HitBoxOff(){
        hit = false;
        yield return new WaitForSeconds(1.5f);
        hit = true;
    }
    void OnTriggerEnter2D(Collider2D target){
        Debug.Log("Collision detected with: " + target.gameObject.name); // Check if the collision is being detected
        if(target.tag == "Enemy"){
        Debug.Log("Enemy collision detected"); // Check if the tag comparison is working
        if(hit == true){
            StartCoroutine(HitBoxOff());
            health--;
            Debug.Log("Player health reduced to: " + health); // Check if health is being reduced
        }
    }
    }

}

