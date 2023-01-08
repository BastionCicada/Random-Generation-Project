using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public GameObject[] arena; // This calls Arenas as a gameobject array
    public GameObject choosenarena; // This is for the choosen arena that the array chooses
    int index; // This indexes the array and is used to pull a random number




    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, arena.Length); // This gets the index by random ranging the arena array
        choosenarena = arena[index]; // This chooses an arena from the array

        Instantiate(choosenarena, new Vector3 (0, 0, 0), Quaternion.identity); // This instantiates the arena into the world

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
