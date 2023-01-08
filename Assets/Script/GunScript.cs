using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage; // This float is used for the damage the weapon will use
    public float weaponrange; // this dedicates the weapons range
    public float firerate; // This float is for the weapons firerate
    public Transform activecamera; // this transform is used to take into account the active camera
    public float fireratecycle = 0f; // this is used for the cycle between the firerate

    void Update()
    {
       if (Input.GetButtonDown("Fire1") && Time.time >= fireratecycle) // This code is what's used to actually fire the gun
       {
        fireratecycle = Time.time + 1f/firerate;
        FireWeapon(); // this calls void fireweapon
       } 
    }

    void FireWeapon()
    {
        RaycastHit shothit; // this is used to fire out a raycast
        if (Physics.Raycast(activecamera.transform.position, activecamera.transform.forward, out shothit)) // this fires out the raycast from the origin point of the gun
        {
            Debug.Log(shothit.transform.name); // This puts a debug in the console which comes up with the name of the object hit

            HealthSystem target = shothit.transform.GetComponent<HealthSystem>(); // This calls the damage function from the HealthSystem Script
            if(target != null) 
            {
                target.TakeDamage(damage); // This calls the damage function from the HealthSystem
            }

        }
    }

}
