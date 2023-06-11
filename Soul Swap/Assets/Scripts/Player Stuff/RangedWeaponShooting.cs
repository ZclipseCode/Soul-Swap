using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RangedWeaponShooting : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletCooldownTimer = 0f;
    [SerializeField] bool canPlayerShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMainAttack(InputAction.CallbackContext context)
    {
        //movementInput = context.ReadValue<Vector2>();

        //Debug.Log("Gun Fired");

        if (canPlayerShoot) 
        { 

            Shoot();

            bulletCooldownTimer = 0f;
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(bulletCooldownTimer);

        if(bulletCooldownTimer < 1)
        {
            canPlayerShoot = false;
        }
        else if(bulletCooldownTimer >= 1)
        {
            canPlayerShoot = true;
        }


        bulletCooldownTimer += Time.deltaTime;
        
    }
}
