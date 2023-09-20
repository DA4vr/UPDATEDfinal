using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    
    private float Horizontal;
    public float speed = 8f;
    public float slowedSpeed = 6f;
    public float JumpingPower=16f;
    public Animator animator;
    public Collider2D box;
    public Collider2D box2;
    public float slideDuration = 0.7f;
    private float sliding = 0f;
    private float spd=0f;

    public Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundlayer;
   
    void FixedUpdate()
    {
        if(Time.time<1f) spd = speed;   
        //slide/roll
        if(Input.GetAxisRaw("Vertical")<0 )
        {
            if(!IsGrounded()) rb.velocity = new Vector2(rb.velocity.x , -JumpingPower/1.5f);
            box.enabled = false;
            box2.enabled = false;
            sliding = Time.time;
        }

        if(Time.time-sliding>slideDuration) 
        {
            box.enabled = true;
            box2.enabled = true;
            
        }
      //jump
        if((Input.GetButtonDown("Jump")|| Input.GetAxisRaw("Vertical")>0) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x , JumpingPower);
            animator.SetBool("jumps",true);
        }
       
            if(IsGrounded() && rb.velocity.y >-6f) animator.SetBool("jumps",false);

        


       
        rb.velocity= new Vector2(speed, rb.velocity.y);

    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }

    
    void OnTriggerEnter2D(Collider2D collisioninfo)
    {
        if(collisioninfo.tag == "Object")
        {
            speed = slowedSpeed;
        }
    }

    void OnTriggerExit2D(Collider2D collisioninfo)
    {
        if(collisioninfo.tag == "Object")
        {
            speed = spd;
        }
    }
}
