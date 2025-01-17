﻿using System.Collections;
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

    AudioSource audioSource;
    public AudioClip frog_lived;
    public AudioClip frog_died;

    public Text GameText; // The object with the "messages" text component
    public Text TimerText; // The object for the timer text

    public GameObject frog; // The frog!
    private Rigidbody frogrb; // Private variable for the frog's rigidbody

    // TODO: Implement!!!!!!!! :>
    private bool savedFrog; // Bool to check if player saved the frog

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //get the audiosource
        GameText.text = GoalMessage; // Load in instructions
        frogrb = frog.GetComponent<Rigidbody>(); // Init the frogrb variable
        savedFrog = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Only decrement timer if above 0 and the frog hasn't been saved
        if (TimerAmount >= 0 && !savedFrog)
        {
            TimerAmount -= Time.deltaTime; // Countdown from timer amount
        }

        TimerText.text = TimerAmount.ToString("f1"); // Constantly update timer text

        if (TimerAmount <= 0 && !savedFrog) // When it hits zero and the frog hasn't been saved
        {
            GameText.text = FailureMessage; // You have died
           
            TimerText.text = "0.0"; // Hard set the text if timer has expired
            frogrb.AddForce(-frog.transform.forward * forceAmount, ForceMode.Impulse); // Force push the frog backward
            
      

         //audioSource.Stop();

        }

        if (Input.GetKeyDown(KeyCode.Space)) //This activates if the player pressed down on the spacebar to save the frog.
        {
          
            GameText.text = SuccessMessage; //You get a pat on the back for being a decent human being.
            
            savedFrog = true; //turns the saved frog boolean true.
            if (savedFrog == true){
             audioSource.PlayOneShot (frog_lived,1);
            }
        }

        
    }
}
