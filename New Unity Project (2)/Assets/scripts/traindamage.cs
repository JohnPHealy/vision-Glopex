using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traindamage : MonoBehaviour
{

    private bool isdead;
    private bool timerRunning;
    private float timer;
    private Animator anim;
    private bool defeated;
    
    // Start is called before the first frame update
    void Start()
    {
       timerRunning = false;
       defeated = false;
       anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
    if(defeated == false){
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
         anim.Play("FallingTrain", 0, 0f);
         GameObject.Find("trainLight").SendMessage("stopLight");
         GameObject.Find("trainSkeleton").SendMessage("postDefeat");
         GameObject.Find("postLight").SendMessage("lightAnimation");
         defeated = true;
        }
}
    }
    
    public void startTimer(){
    
        timerRunning = true;
}
   public void pauseTimer(){                                                        
    
    
        timerRunning = false;
}
}
