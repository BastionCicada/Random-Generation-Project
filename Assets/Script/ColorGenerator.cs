using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGenerator : MonoBehaviour
{

    public Material[] material;
    Renderer MaterialRender;
    int index;



    // Start is called before the first frame update
    void Start()
    {
        MaterialRender = GetComponent<Renderer>();
        MaterialRender.enabled = true;
        MaterialRender.sharedMaterial = material[0];


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
