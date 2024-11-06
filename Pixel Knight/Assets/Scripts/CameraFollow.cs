using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public float scale = 4f;
    
    private Transform t;
   
    void Awake()
    {
        var cam = GetComponent<Camera>(); //Gets the camera into our script here
        cam.orthographicSize = 25; //Sets the size of the camera

    }

    void Start() //Start is called before the first frame update
    {
        t = target.transform;
    }

    
    void Update() // Update is called once per frame
    {
        if(target != null){
            transform.position = new Vector3(t.position.x, t.position.y, transform.position.z); //This creates a camera vector which follows the player.

        }
    }
}
