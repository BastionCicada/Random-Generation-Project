using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour

{
    public GameObject[] InputItem; // this checks for the item thats inputted which will be generated into a grid
    public int gridX; // This sets an interger for grid x 
    public int gridZ; // This sets an interger for grid y 
    public float gridSpacingOffset = 1f; // this float is used for the spacing of the grid
    public Vector3 gridOrigin = Vector3.zero; // This sets the Grid Origin to zero on the worldpoint

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }


    void Spawn()
    {
        for (int x= 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrigin; // This is what is used for the spawn position of the inputted items
                InputSpawn(spawnPosition, Quaternion.identity);

            }
        }
    }

    void InputSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, InputItem.Length);
        GameObject clone = Instantiate(InputItem[randomIndex], positionToSpawn, rotationToSpawn);
    }


}
