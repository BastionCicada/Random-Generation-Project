using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // This allows unity to use the scene manager

public class GameReset : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) // This code detects if the R key has been pressed down
        {
            SceneManager.LoadScene(0); // This uses the scene manager to escencially reload the scene
        }
    }
}
