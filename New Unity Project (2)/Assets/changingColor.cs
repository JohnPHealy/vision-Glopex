using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changingColor : MonoBehaviour
{
    // Start is called before the first frame update
  public Material powerOff;
public Material powerOn;
public GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void changing(float coloration)
    {
   
    myObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color(coloration, coloration, coloration));
    }
    
    void reverting(float coloration)
    {
    myObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color(coloration*2, coloration*2, coloration*2));
    }
}

