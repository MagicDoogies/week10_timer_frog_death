using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeltaTimer : MonoBehaviour
{
    public float TimerAmount = 10; // How long the countdown timer is
    public float forceAmount = 50f; // How strong to make the frog's death force
    public string GoalMessage; // Instructions on how to play the game
    public string SuccessMessage; // WinGame message
    public string FailureMessage; // Game Over Message

    public Text GameText; // The object with the "messages" text component
    public Text TimerText; // The object for the timer text

    public GameObject frog; // The frog!
    private Rigidbody frogrb; // Private variable for the frog's rigidbody

    // TODO: Implement!!!!!!!! :>
    private bool savedFrog; // Bool to check if player saved the frog

    // Start is called before the first frame update
    void Start()
    {
        GameText.text = GoalMessage; // Load in instructions
        frogrb = frog.GetComponent<Rigidbody>(); // Init the frogrb variable
        savedFrog = false;
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

        if (TimerAmount <= 0) // When it hits zero
        {
            GameText.text = FailureMessage; // You have died
            TimerText.text = "0.0"; // Hard set the text if timer has expired
            frogrb.AddForce(-frog.transform.forward * forceAmount, ForceMode.Impulse); // Force push the frog backward
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("here");

        }


    }
}
