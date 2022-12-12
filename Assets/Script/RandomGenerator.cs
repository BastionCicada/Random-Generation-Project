using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public GameObject[] arena;
    public GameObject choosenarena;
    int index;




    // Start is called before the first frame update
    void Start()
    {

        index = RandomGenerator.Range(0, arena.Length);
        choosenarena = arena[index];


        Instantiate(choosenarena, new Vector3(0, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
