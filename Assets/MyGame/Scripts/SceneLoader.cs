using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void GoToGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

}

