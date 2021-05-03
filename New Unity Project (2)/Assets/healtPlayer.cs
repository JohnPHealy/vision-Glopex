using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healtPlayer : MonoBehaviour
{
   public int maxHealth = 10;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col)collision
    {
    if (col.gameObject.tag == "TrainDamagingCollider")
    {
    
    }
    }
}
