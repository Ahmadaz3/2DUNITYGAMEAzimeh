using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerMovment : MonoBehaviour
{
    
    public float speed = 10f;
    private Rigidbody2D rb;
    public bool isGrounded;
    private SpriteRenderer sr;
    private Animator anim;
    private Vector3 startPosition;
    public Color newColor = Color.red;
    MangeHealth mangeHealth;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        mangeHealth = FindObjectOfType<MangeHealth>();
    }
    private void Update()
    {
        // get the x-axis Movement
        float x = Input.GetAxis("Horizontal");
        // set the movement
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
        // manage the Jump Player Can not Jump if he not grounded
        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) 
        {
            jump();
        }
        // FLip the Player
        if (x > 0)
        {
            sr.flipX = false;
        }
        if (x < 0)
        {
            sr.flipX = true;
        }
        // set the run animation if the Horizontal Input 
        anim.SetBool("run",x!=0);
        // every frame check if the user in the Ground or not
        anim.SetBool("grounded", isGrounded);

    }
  
   

    // OnCollisionEnter2D is called when the player collides with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") // check if the collision was with the ground
        {
            isGrounded = true; // set the flag to true, indicating that the player is now on the ground
            
        }
        if (collision.gameObject.tag == "Jump") // check if the collision was with the jumpPad
        {
            isGrounded = true;
            rb.velocity = new Vector2(rb.velocity.x, 25f);


        }
        if (collision.gameObject.CompareTag("ResetObject"))
        {
            mangeHealth.takedamge();
            mangeHealth.UpdateHeart();
            MoveToStartPosition();
        }

   
    }
    // jump the player
    private void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 20f);
        anim.SetTrigger("Jump");
        // set the bool to false, indicating that the player is no longer on the ground
        isGrounded = false; 
       
    }
     public void MoveToStartPosition()
    {
        rb.position = startPosition;
    }
    int counter = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("checkPoint1"))
        {
            if (counter == 0)
            {
                mangeHealth.heal();
                mangeHealth.UpdateHeart();
            }
            counter++;
            startPosition = transform.position;
            sr.color = newColor;
        }
    }
}
