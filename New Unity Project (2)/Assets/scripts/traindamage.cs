using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traindamage : MonoBehaviour
{

    private bool isdead;
    private bool timerRunning;
    private float timer;
    private Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
       timerRunning = false;
       anim = GetComponent<Animation>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(timerRunning == true)
        {
        timer +=Time.deltaTime;
        GameObject.Find("trainSkeleton").SendMessage("changing", timer);
        GameObject.Find("trainLight").SendMessage("lightIncrease", timer);
        }
        else{
        if(timerRunning == false && timer>0){
        
        timer -=(Time.deltaTime)/4;               
        GameObject.Find("trainSkeleton").SendMessage("reverting", timer);
        GameObject.Find("trainLight").SendMessage("lightDecrease", timer);
        }
        }
        Debug.Log(timer);
        if(timer > 6)
        {
         anim.PlayQueued("FallingTrain", QueueMode.CompleteOthers);
        }

    }
    
    public void startTimer(){
    
        timerRunning = true;
}
   public void pauseTimer(){
    
    
        timerRunning = false;
}
}
