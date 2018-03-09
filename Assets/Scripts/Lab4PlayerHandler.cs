using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4PlayerHandler : MonoBehaviour {
    public string horizontalInput;
    public string jumpKey;


    // Public variables
    public float maxSpeed = 5f;
    public Transform groundCheck;
    public LayerMask defineGround;
    public float jumpForce;

    // Private variables
    private Rigidbody2D rBody;
    private SpriteRenderer sRend;
    private Animator animator;

    private float groundCheckRadius = 0.2f;
    private bool isGrounded = false;


    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        sRend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetAxis(jumpKey) > 0)
        {
            
            Vector2 velocity = rBody.velocity;
            if(Mathf.Approximately(velocity.y, 0))
            {
                rBody.AddForce(new Vector2(0, jumpForce));

            }
        }
    }

    // Guarenteed to be called at defined time intervals. USE FOR PHYSICS!!!
    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, defineGround);
        animator.SetBool("Ground", isGrounded);

        //pass vertical velocity to animator
        animator.SetFloat("vSpeed", rBody.velocity.y);


        //Debug.Log("Grounded?"+ isGrounded);
        float moveHoriz = Input.GetAxis(horizontalInput);

        // Debug.Log("Horizontal value= " + moveHoriz);
        animator.SetFloat("hSpeed", Mathf.Abs(moveHoriz));

        rBody.velocity = new Vector2(moveHoriz * maxSpeed, rBody.velocity.y);

        if (moveHoriz > 0)
        {
            sRend.flipX = false;
        }
        else if (moveHoriz < 0)
        {
            sRend.flipX = true;
        }
    }
}
