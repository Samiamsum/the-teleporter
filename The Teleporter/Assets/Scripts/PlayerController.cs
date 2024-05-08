using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    [SerializeField] private AnimationStateChanger asc;
    SpriteRenderer spriteRenderer;
    //public SpriteRenderer weaponSpriteRenderer; // Reference to the weapon's SpriteRenderer
    public Weapon currentWeapon; //
    public Transform weaponTransform;
    public Transform firePoint;
    private float nextTimeOfFire = 0;
    Vector2 moveDirection;
    Vector2 mousePosition;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //CHANGEWEAPON METHOD
        //if collide with weapon
        // call ChangeWeapon method

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

        //mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        //Vector2 aimDirection = mousePosition - rb.position;
        //float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = aimAngle;

    }   

    //weapon pick up method
    //void ChangeWeapon(Weapon newWeapon)
    //{
    //    currentWeapon = newWeapon;
        // Update the weapon's sprite renderer to reflect the new weapon
    //    weaponSpriteRenderer.sprite = currentWeapon.currentWeaponSprite;
    //}

}

