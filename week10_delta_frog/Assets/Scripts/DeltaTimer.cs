using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeltaTimer : MonoBehaviour
{
    public float TimerAmount = 10; //how long the countdown timer is
    public string GoalMessage; //instructions on how to play the game
    public string SuccessMessage; //WinGame message
    public string FailureMessage; //Game Over Message

    public Text GameText; //The object with the "messages" text component
    public Text TimerText; //The object for the timer text



    // Start is called before the first frame update
    void Start()
    {
        GameText.text = GoalMessage; //Load in instructions
    }

    // Update is called once per frame
    void Update()
    {
        TimerAmount -= Time.deltaTime; //countdown from timer amount

        if(TimerAmount<=0) // when it hits zero
        {
            GameText.text = FailureMessage; //you have died
        }
        

    }
}
