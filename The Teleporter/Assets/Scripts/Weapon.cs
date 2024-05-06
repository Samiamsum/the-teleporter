using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    public Sprite currentWeaponSprite;
    public GameObject bulletPrefab;
    //public Transform firePoint;
    public float fireRate = 1;
    public float damage = 1f;
    public float fireForce = 20f;
 
    public void UpdateWeaponRotation(Transform weaponTransform)
    {
        //Move weapon in direction of mouse
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - weaponTransform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        weaponTransform.rotation = rotation;
    }

    public void Fire(Transform firePoint)
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }


}
