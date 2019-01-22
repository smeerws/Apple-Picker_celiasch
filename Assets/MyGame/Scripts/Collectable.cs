using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    private const string TAGPLAYER = "Player";
    private const string TAGGROUND = "Floor";
    private const string TAGBADAPPLE = "BadApple";

    public SceneLoader sceneLoader;

    int numberApples;

    // Use this for initialization
    void Start()
    {
        //Methode ResetApple() Reset the apple counter to 0)       
        numberApples = 0;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger enter" + collision.tag);

        if (collision.tag == TAGGROUND)
        {
            if (numberApples >= 0)
            {
                numberApples--;
            }

            Destroy(gameObject);
        }

        else if (collision.tag == TAGPLAYER && gameObject.tag == "GoodApple")
        {
            numberApples++;
            Destroy(gameObject);
        }

        else if(collision.tag == TAGPLAYER && gameObject.tag == "BadApple")
        {
            sceneLoader.GoToGameOverScene();
        }
    }
    


	
	// Update is called once per frame
	void Update () {
// Methode CountApple() Count the apples the player touches)
// Methode BadApple() if the character touches a bad apple, stop the game)
//Methode FallDown () the apples go down)
    }
}
