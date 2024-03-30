using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Weapon weapon;
    public Transform weaponTransform;
    public Transform firePoint;
    Vector2 moveDirection;
    Vector2 mousePosition;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        weapon.UpdateWeaponRotation(weaponTransform);
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if(Input.GetMouseButtonDown(0))
        {
            weapon.Fire(firePoint);
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

}
