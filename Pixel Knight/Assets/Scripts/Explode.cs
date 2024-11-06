using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    private CapsuleCollider2D playerCollider;

    void Start()
    {
        // Get the CapsuleCollider2D component attached to the Player GameObject
        playerCollider = GetComponent<CapsuleCollider2D>();
    }

    // This method is called when another Collider2D enters the trigger zone of this GameObject.
    void OnTriggerEnter2D(Collider2D target)
    {
        // Check if the entering GameObject has the "Deadly" tag

        if (target.gameObject.CompareTag("Lethal")){
            
            // Disable the CapsuleCollider2D on the Player to prevent further collisions
            if (playerCollider != null){
                playerCollider.enabled = false;
            }
        }
    }

    // This method is called when a collision with another Collider2D occurs.
    void OnCollisionEnter2D(Collision2D target)
    {
        // Check if the colliding GameObject has the "Deadly" tag
        if (target.gameObject.CompareTag("Lethal")){

            // Disable the CapsuleCollider2D on the Player to prevent further collisions
            if (playerCollider != null){
                playerCollider.enabled = false;

            }
        }
    }
}