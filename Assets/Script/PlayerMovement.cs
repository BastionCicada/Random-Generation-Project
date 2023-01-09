using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSmoothTime; // This is the smoothness between movement
    public float GravityStrength; // This is the strength of the gravity 9.81 being closest to earth
    public float JumpStrength; // This is how strong the strength of the jump is
    public float WalkSpeed; // Self Explanitory, walking speed
    public float RunSpeed; // Self Explanitory, running speed.

    private CharacterController Controller; // this defines the character controller as Controller
    private Vector3 CurrentMoveVelocity; // This takes into account current move velocity
    private Vector3 MoveDampVelocity; // This is taking into account velocity dampining when moving
    private Vector3 CurrentForceVelocity; // This is the current force applied to the player moving
   
    
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>(); // This binds the controller to the charactercontroller component
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerInput = new Vector3 // This takes into account the player input.
        {
            x = Input.GetAxisRaw("Horizontal"), // This is for horizontal movement
            y = 0f,
            z = Input.GetAxisRaw("Vertical")    // This is for vertical movement

        };

        if (PlayerInput.magnitude > 1f) 
        {
            PlayerInput.Normalize();
        }

        Vector3 MoveVector = transform.TransformDirection(PlayerInput); // This transform is used for player movement
        float CurrentSpeed = Input.GetKey(KeyCode.LeftShift) ? RunSpeed : WalkSpeed; // This ? Operator in this regard 'switches' between runspeed and walkspeed

        CurrentMoveVelocity = Vector3.SmoothDamp(
            CurrentMoveVelocity,
            MoveVector * CurrentSpeed, // this multiplies the move vector by the current speed, allowing movement
            ref MoveDampVelocity,
            MoveSmoothTime //This gradually changes a vector towards a desired goal over time
        );

        Controller.Move(CurrentMoveVelocity * Time.deltaTime);

        Ray groundCheckRay = new Ray(transform.position, Vector3.down); // This is the raycast used to check if the player is on the ground
        if (Physics.Raycast(groundCheckRay, 1.1f)) // this checks the distances between the character and the raycast
        {
            CurrentForceVelocity.y = -2f; // This sets the y axis jumping velocity to -2f

            if (Input.GetKey(KeyCode.Space)) // This is for player jumping
            {
                CurrentForceVelocity.y = JumpStrength; // This sets the velocity equal to the jump strength

            }
        }
        else
        {
            CurrentForceVelocity.y -= GravityStrength * Time.deltaTime;

        }

         Controller.Move(CurrentForceVelocity * Time.deltaTime);
     
    }
}
