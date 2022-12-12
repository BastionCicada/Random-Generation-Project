using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHandler : MonoBehaviour
{
    public Material[] ColorMaterial;
    public Material chosenMaterial;
    int index;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = ColorMaterial[0];
        index = Random.Range(0, ColorMaterial.Length);
        chosenMaterial = ColorMaterial[index];
        
        if(gameObject.tag == "Floor")
        {
            rend.sharedMaterial = chosenMaterial;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
