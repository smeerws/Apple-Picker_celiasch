using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    private const string TAGPLAYER = "Player";
    private const string TAGGROUND = "Floor";
    private const string TAGBADAPPLE = "BadApple";
    private const string TAGGOODAPPLE = "GoodApple";

    public DataContainer appleCounter;
    public SceneLoader sceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);

        if (collision.tag == TAGPLAYER && gameObject.tag == TAGGOODAPPLE)
        {
            
            appleCounter.apples++;
            Destroy(gameObject);
        }

        else if(collision.tag == TAGPLAYER && gameObject.tag == TAGBADAPPLE)
        {
            sceneLoader.GoToGameOverScene();
        }
  
    }
    
}
