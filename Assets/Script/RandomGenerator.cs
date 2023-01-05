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
        Instantiate(choosenarena, new Vector3(0, 0, 0), Quaternion.identity);
        choosenarena = arena[index];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
