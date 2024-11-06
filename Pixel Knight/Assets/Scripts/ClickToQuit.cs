using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //You MUST include this if you want to work with scenes / change scenes
using UnityEngine.UI; //You MUST include this to work with User Interfaces (buttons in this case)

public class ClickToQuit : MonoBehaviour
{
	public Button quitButton;

	void Start () {
		Button btn = quitButton.GetComponent<Button>(); //Stores a button in the 'btn' variable
		btn.onClick.AddListener(TaskOnClick); //Checks to see if the button is clicked.
	}

	void TaskOnClick(){
		Application.Quit(); //Quits if the button is clicked
	}
}




