using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
      GameObject[] goldenCubes; // This makes an array looking for golden cubes,
      goldenCubes = GameObject.FindGameObjectsWithTag("WinCondition"); // this looks for goldencubes with the tag WinCondition

      if (goldenCubes.Length == 0) //This looks for all the goldencubes left
      {
        Debug.Log("All Golden Cubes broken, restarting!");
        SceneManager.LoadScene(0); // Restarts the scene
        
      }
    }

  


    
    
}
