using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //If an Object with the tag 'Player' collides with the collectible, the collectible disappears.
    void OnTriggerEnter2D(Collider2D target){
        if(target.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
