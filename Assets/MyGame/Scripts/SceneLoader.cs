using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Methode LoadStartScene() Load Startscene if the game is opened)	
        //Methode LoadMainScene() Load Mainscene if the Play Button is clicked or if the replay button is clicked)
        //Methode LoadGameOverScene() Load GameOver scene if time is over or a bad apple is touched)
    }
}
