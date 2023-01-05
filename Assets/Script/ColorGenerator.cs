using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGenerator : MonoBehaviour
{

    public Material[] ColorMaterial;
    public Material chosenMaterial;
    private Renderer MaterialRender;
    int index;
    

    // Start is called before the first frame update
    void Start()
    {
        MaterialRender = GetComponent<Renderer>();
        MaterialRender.enabled = true;
        MaterialRender.sharedMaterial = ColorMaterial[0];
        index = Random.Range(0, ColorMaterial.Length);
        chosenMaterial = ColorMaterial[index];

        if(gameObject.tag == "ColorTag")
        {
            MaterialRender.sharedMaterial = chosenMaterial;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
