using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject choosenprefabs;
    int index;




    // Start is called before the first frame update
    void Start()
    {
        Instantiate(choosenprefabs, new Vector3(0, 0, 0), Quaternion.identity);
        choosenprefabs = prefabs[index];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
