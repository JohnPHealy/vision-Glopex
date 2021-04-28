using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageovertime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other){
    
    if(other.gameObject.tag=="TrainCollider"){
        Debug.Log("entrato");

        GameObject.Find("treno").SendMessage("startTimer");
}
}
 public void OnTriggerExit(Collider other){
 
    if(other.gameObject.CompareTag("TrainCollider")){
        Debug.Log("uscito");

        GameObject.Find("treno").SendMessage("pauseTimer");
        }
}
}
