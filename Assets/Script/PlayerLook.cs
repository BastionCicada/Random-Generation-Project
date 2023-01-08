using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public Transform PlayerCamera; // This is the location of the players camera
    public Vector2 Sensitivity; // this is the vector2 used for the mouse based sensitivity
    private Vector2 XYRotation; // this accounts for the rotation

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // This locks the cursor to the centre of the screen
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MouseInput = new Vector2
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };

        XYRotation.x -= MouseInput.y * Sensitivity.y;
        XYRotation.y += MouseInput.x * Sensitivity.x;

        XYRotation.x = Mathf.Clamp(XYRotation.x, -90f, 90f); // This clamps the view to stop the player from looking higher then this

        transform.eulerAngles = new Vector3(0f, XYRotation.y, 0f);
        PlayerCamera.localEulerAngles = new Vector3(XYRotation.x, 0f, 0f);


        
    }
}
