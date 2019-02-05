using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public Text collected;

    private const string TAGPLAYER = "Player";
    private const string TAGGROUND = "Floor";
    private const string TAGBADAPPLE = "BadApple";

    public SceneLoader sceneLoader;

    int numberApples;

    // Use this for initialization
    void Start()
    {
        //Reset the apple counter to 0)       
        numberApples = 0;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
 
        if (collision.tag == TAGPLAYER && gameObject.tag == "GoodApple")
        {
            numberApples++;
            Destroy(gameObject);
        }

        else if(collision.tag == TAGPLAYER && gameObject.tag == "BadApple")
        {
            sceneLoader.GoToGameOverScene();
        }
  
    }
    
}
