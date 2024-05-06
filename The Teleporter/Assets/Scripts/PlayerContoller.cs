using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    //public SpriteRenderer weaponSpriteRenderer; // Reference to the weapon's SpriteRenderer
    public Weapon currentWeapon; //
    public Transform weaponTransform;
    public Transform firePoint;
    private float nextTimeOfFire = 0;
    Vector2 moveDirection;
    Vector2 mousePosition;
    void Start()
    {
 
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
