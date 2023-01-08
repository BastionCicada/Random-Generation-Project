using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
      GameObject[] goldenCubes;
      goldenCubes = GameObject.FindGameObjectsWithTag("WinCondition");

      if (goldenCubes.Length == 0)
      {
        Debug.Log("All Golden Cubes broken, restarting!");
        SceneManager.LoadScene(0);
        
      }
    }

  


    
    
}
