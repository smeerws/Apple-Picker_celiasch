using UnityEngine;

public class DisplayCountdown : MonoBehaviour
{
    public Countdown countdown; 

    // Use this for initialization
    void Start ()
    {
        //countdown.text = (timeLeft + " sec"); this isnt working and i dont know why so i made it a comment
        //Methode ResetCountdown() Reset the counter to 60 sec) 		
    }

    // Update is called once per frame
    void Update ()
    {
        countdown = GetComponent<Countdown>();
        //Methode DisplayTime() Get Countdown Data, Display Data in Time Text)		
    }
}
