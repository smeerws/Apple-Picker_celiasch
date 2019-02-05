using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCountdown : MonoBehaviour
{
    public Countdown countdown; 

    void Awake()
    {
        countdown = GetComponent<Countdown>();
    }


    // Use this for initialization
    void Start ()
    {
        countdown.text = (timeLeft + " sec");
        //Methode ResetCountdown() Reset the counter to 60 sec) 		
    }

    // Update is called once per frame
    void Update ()
    {
        //Methode DisplayTime() Get Countdown Data, Display Data in Time Text)		
    }
}
