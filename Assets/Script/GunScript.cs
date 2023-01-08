using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage; // This float is used for the damage the weapon will use
    public float weaponrange; // this dedicates the weapons range
    public float firerate; // This float is for the weapons firerate
    public Transform activecamera; // this transform is used f
    public float fireratecycle = 0f;

    void Update()
    {
       if (Input.GetButtonDown("Fire1") && Time.time >= fireratecycle)
       {
        fireratecycle = Time.time + 1f/firerate;
        FireWeapon();
       } 
    }

    void FireWeapon()
    {
        RaycastHit shothit;
        if (Physics.Raycast(activecamera.transform.position, activecamera.transform.forward, out shothit))
        {
            Debug.Log(shothit.transform.name);

            HealthSystem target = shothit.transform.GetComponent<HealthSystem>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

        }
    }

}
