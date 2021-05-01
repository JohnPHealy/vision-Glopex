using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postFightLight : MonoBehaviour
{
    // Start is called before the first frame update
      Light myLight; 
      private float timer;
      private bool active;
    // Start is called before the first frame update
    void Start()
    {
         myLight = GetComponent<Light>();
         myLight.intensity = 0;
    }
    void Update()
    {
    
    timer +=Time.deltaTime;
    
    if(active == true){
    
    if(timer >0.5){
    
    myLight.intensity = 10;
        if(timer >1.5)
            myLight.intensity = 0;
        if(timer >2)
            myLight.intensity = 10;
        if(timer >3)
            timer = 0;
    
    }
    
    }
    
    
    }
    // Update is called once per frame
    public void lightAnimation(){
    active = true;
    }
    }
