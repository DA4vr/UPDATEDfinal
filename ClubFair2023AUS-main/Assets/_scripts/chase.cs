using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform enemy; 
   public GameObject p;
   public Transform player; 
   public Rigidbody2D en;
   public float chaseSpeed = 4f;
   private float spd;
   
    // Update is called once per frame
    void Update()
    {
        
        if(p)
        {
            if(chaseSpeed<p.GetComponent<playerMovement>().speed-0.3f) chaseSpeed = p.GetComponent<playerMovement>().speed-0.3f;
            if(enemy.position.x<player.position.x) en.velocity = new Vector2(chaseSpeed,0);
            if(enemy.position.x>=player.position.x) en.velocity = new Vector2(-chaseSpeed,0);
        }
        else{
            en.velocity = new Vector2(0,0);
        }
    }
}
