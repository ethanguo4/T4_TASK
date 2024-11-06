using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Important, if working with scenes you MUST include this.
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target){
        if(target.gameObject.tag == "Player"){ //If the end of level collectible collides with the player
            Destroy(gameObject); //Remove player from screen
            LoadNextScene(); //Loads next scene
        }
    }
    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1; //Gets the next scene

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings){ //If there is another scene
            SceneManager.LoadScene(nextSceneIndex); //Loads the next scene
        }
        else{
            SceneManager.LoadScene("SplashScreen"); //Load SplashScreen if there are no more scenes
        }
    }
}

