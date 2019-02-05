using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{

    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object

    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }

    void Update()
    {

        if (timeLeft > 0)
        {
            countdown.text = (timeLeft + " sec"); //Showing the Score on the Canvas  
        }
        else
        {
            PlayerPrefs.SetFloat("Time", timeLeft);
            SceneManager.LoadScene("GameOver");
        }
    }

    //Simple Coroutine

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }

    }
}
