using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
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
