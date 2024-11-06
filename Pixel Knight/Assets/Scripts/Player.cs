using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Required if we want to work with Scenes



public class Player : MonoBehaviour
{
    public float speed = 150f; //Stores player speed as a float
    public Vector2 maxVelocity = new Vector2(60, 100); //Stores player velocity (60x, 100y)
    public float jetSpeed = 200f; //Stores the jump speed
    public bool standing; //Identifies whether the player is standing or not (True/False)
    public float standingThreshold = 4f; //Stores a variable to check if the player is standing on the ground
    public float airSpeedMultiplier = .3f; //Multiplies the air speed of the player

    private Rigidbody2D body2D; //Creates a variable for the RigidBody2D component
    private SpriteRenderer renderer2D; //Creates a variable to render the sprite
    private PlayerController controller; //Creates a variable for the controller (created in a separate script)
    private Animator animator; //Creates a variable to work with the Player animations
    public CapsuleCollider2D alive; //Creates a variable to check if the player is alive
    private bool isJumping = false;
    private bool canJump = false;

    AudioSource audioData;
    
  /*//Starts before the first frame. Gets the RigidBody2D, SpriteRenderer, PlayerController 
  and Animator from the Player sprite and stores them in relevant variables*/
    void Start() 
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();

        
    }

    void Update()
    {
        animator.SetInteger("AnimState", 0);
        var absVelX = Mathf.Abs(body2D.velocity.x); //Creates a variable to store horizontal movement velocity (x)
        var absVelY = Mathf.Abs(body2D.velocity.y); //Creates a variable to store vertical movement velocity (y)
        var forceY = 0f; //Creates a variable to store force

          
        // Access the player's Y-axis position
        float playerYPosition = transform.position.y;
        if (playerYPosition < -150)  //Check if the player has fallen below a certain position on the screen and return to the Splash Screen if true
        {
            SceneManager.LoadScene("SplashScreen");
        }
    
        if (absVelY <= standingThreshold) //Check if the player is standing on the ground or not
        {
            
            standing = true;

            if (controller.moving.y > 0 && !isJumping && canJump)  // Check if the player is moving upwards and allow jumping
            {
                //audioData.Play(0);
                isJumping = true;
                canJump = false; //Prevent multiple jumps until landing.
                
                forceY = jetSpeed * controller.moving.y;
                animator.SetInteger("AnimState", 2);
                

                
            }
            else if (absVelY == 0 && !standing) //Check if the player is not moving vertically and set the animation state accordingly
            {
               animator.SetInteger("AnimState", 2);
            }
            
        }
        else
        {
            animator.SetInteger("AnimState", 2);
            standing = false;
        }

        var forceX = 0f;

        if (controller.moving.x != 0) //Check if the player is moving horizontally
        {
            if (absVelX < maxVelocity.x) //Check if the player's horizontal velocity is within limits and adjust force accordingly
            {
                var newSpeed = speed * controller.moving.x;

                forceX = standing ? newSpeed : (newSpeed * airSpeedMultiplier);

                renderer2D.flipX = forceX < 0;
            }

            animator.SetInteger("AnimState", 1); //Set the animation state for horizontal movement
        }
      

        body2D.AddForce(new Vector2(forceX, forceY)); //Apply the calculated forces to the player's Rigidbody2D
    }

    
    void OnCollisionEnter2D(Collision2D collision) //Function to enable jumping again after landing.
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            canJump = true;
        }
    }




}
