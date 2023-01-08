using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public float health = 50f; // This defines a float as Health which is the base for the health system, it by default is defined as 50
   
    
    public void TakeDamage (float amount) // this defines the term Amount of a float while on the TakeDamage void
    {
        health -= amount; // this subtracts the health from the amount 
        if (health <= 0f) // if the health of the object becomes 0 
        {
            Die(); // Calls the die function
        }
    }



    // Update is called once per frame
    void Die ()
    {
        Destroy(gameObject); // This destroys the attached gameobject
    }
}
