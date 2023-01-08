using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGenerator : MonoBehaviour
{

    public Material[] ColorMaterial; // This is an array of colors inputted
    public Material chosenMaterial; // this is the chosen material from the sequence
    private Renderer MaterialRender; // this is the renderer for materials
    int index; // This indexes the array and is used to pull a random number
    

    // Start is called before the first frame update
    void Start()
    {
        MaterialRender = GetComponent<Renderer>(); // This calls for the renderer
        MaterialRender.enabled = true; // This makes sure that the renderer is active
        MaterialRender.sharedMaterial = ColorMaterial[0]; // the MaterialRender designates the ColorMaterial as a shared material
        index = Random.Range(0, ColorMaterial.Length); // this designates the index between a random number of 0 and the array.
        chosenMaterial = ColorMaterial[index]; // This chooses a material from the array

        if(gameObject.tag == "ColorTag") // this looks for the a gameobject with the tag 'ColorTag'
        {
            MaterialRender.sharedMaterial = chosenMaterial; // this applies the material
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
