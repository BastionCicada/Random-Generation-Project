using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public GameObject arenas;
    public GameObject choosenarena;
    int index;




    // Start is called before the first frame update
    void Start()
    {
        Instantiate(arenas, new Vector3(0, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
