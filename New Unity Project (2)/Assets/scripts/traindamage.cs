using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traindamage : MonoBehaviour
{

    private bool isdead;
    private bool timerRunning;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
       timerRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerRunning == true)
        {
        timer +=Time.deltaTime;
        }
        Debug.Log(timer);

    }
    public void startTimer(){
    
        timerRunning = true;
}
   public void pauseTimer(){
    
    
        timerRunning = false;
}
}
