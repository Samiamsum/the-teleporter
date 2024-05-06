using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using PlayerController;

public class WeaponPickUp : MonoBehaviour
{
    
    public Weapon weapon;

    private void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag == "Player"){
            obj.GetComponent<PlayerController>().currentWeapon = weapon;
            obj.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = weapon.currentWeaponSprite;
            Destroy(gameObject);
        }
    }
}
