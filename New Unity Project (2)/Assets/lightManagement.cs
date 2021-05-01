using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightManagement : MonoBehaviour
{

    Light myLight; 
    // Start is called before the first frame update
    void Start()
    {
         myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    public void lightIncrease(float value)
    {
        myLight.intensity = value*2;
    
    }
     public void lightDecrease(float value)
    {
        myLight.intensity = value*2;
    
    }
    public void stopLight()
    {
    myLight.intensity = 0f;
    }
    }
