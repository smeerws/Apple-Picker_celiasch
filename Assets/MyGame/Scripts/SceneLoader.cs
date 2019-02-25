using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main");
        FindObjectOfType<DataContainer>().apples = 0;
    }

    public void GoToGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

}

