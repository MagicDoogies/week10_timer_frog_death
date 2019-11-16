using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeltaTimer : MonoBehaviour
{
    public float TimerAmount = 10; // How long the countdown timer is
    public string GoalMessage; // Instructions on how to play the game
    public string SuccessMessage; // WinGame message
    public string FailureMessage; // Game Over Message

    public Text GameText; // The object with the "messages" text component
    public Text TimerText; // The object for the timer text



    // Start is called before the first frame update
    void Start()
    {
        GameText.text = GoalMessage; // Load in instructions
    }

    // Update is called once per frame
    void Update()
    {
        // Only decrement timer if above 0
        if (TimerAmount >= 0)
        {
            TimerAmount -= Time.deltaTime; // Countdown from timer amount
        }

        TimerText.text = TimerAmount.ToString("f1"); // Constantly update timer text

        if(TimerAmount<=0) // When it hits zero
        {
            GameText.text = FailureMessage; // You have died
            TimerText.text = "0.0"; // Hard set the text if timer has expired
        }
        

    }
}
