using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class torchManagement : MonoBehaviour
{

    private float Mousex;
    private float Mousey;
    private float rotated;
    private float changeto;
    private Vector3 posizione;
    

    // Start is called before the first frame update
    void Start()
    {
        rotated=0;
      
    }

    // Update is called once per frame
    void Update()
    {
       //transform.position = new Vector3((GameObject.Find("shadow").transform.position.x),(GameObject.Find("shadow").transform.position.y), (GameObject.Find("shadow").transform.position.z));
        transform.position = Vector3.MoveTowards(transform.position,  GameObject.Find("Head").transform.position,10f);
    }
    
   public void arrowMove(InputAction.CallbackContext context){
    
        var rotation = context.ReadValue<Vector2>();
        
        if(rotation.x==0f && rotation.y==1.0f){
        changeto=180;
        transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, changeto);
        Debug.Log(changeto);
        }
        
        if(rotation.x==1.0f && rotation.y==0f){
        changeto=90;
        transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, changeto);
        Debug.Log(changeto);
        }
        
         if(rotation.x==0f && rotation.y==(1.0f*-1)){
        changeto=0;
        transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, changeto);
        Debug.Log(changeto);
        }
        
         if(rotation.x==(1.0f*-1) && rotation.y==0f){
        changeto=-90;
        transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, changeto);
        Debug.Log(changeto);
        }
        
        
       
      
        
        
        
        
        /*if(context.ReadValue<float>() = (-1,0)){
        changeto=-90;
        transform.Rotate(0f,0f,changeto);}*/
            
    }
}
