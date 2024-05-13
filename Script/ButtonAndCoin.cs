using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAndCoin : MonoBehaviour
{
    

     [Header("COIN")]
    public GameObject turret1;
    public GameObject turret2;
    public GameObject turret3;
    public Text coinText; // Reference to the UI text component displaying the coin value
    private int coinValue = 0; // Current coin value
    private int BarrelAmount = 70; // Amount to subtract when button is clicked
    private int CannonAmount = 40;
    private int ArtillerylAmount = 110;
    public Button myButton;
    public Button myButton1;
    public Button myButton2;


     void Start()
    {
        //coin ------------------------------------------------------------------
         
        coinValue = 0;
        UpdateCoinText();

        // Start the method to increase coin value every second
        InvokeRepeating("IncreaseCoinValue", 1f, 1f);

        // Add listener to the button click event
        if (myButton != null)
        {
            myButton.onClick.AddListener(SubtractCoin1);
            
        }
         if (myButton1 != null)
        {
            myButton1.onClick.AddListener(SubtractCoin2);
            
           
        }
         if (myButton2 != null)
        {
            myButton2.onClick.AddListener(SubtractCoin3);
           
        }
       
        
        
    }
    
    void IncreaseCoinValue()
    {
        // Increase the coin value by 10 every second
        coinValue += 10;

        // Check if coin value is sufficient to enable turret
        if (coinValue >= 40) // cannon
        {
            turret1.SetActive(true);
        }
        if (coinValue >= 70) // barrel
        {
            turret2.SetActive(true); //art
        }
        if (coinValue >= 110)
        {
            turret3.SetActive(true);
        }
       
        // Update the coin value text
        UpdateCoinText();
    }
    

    
    

    void UpdateCoinText()
    {
        // Update the UI text to display the current coin value
        coinText.text = "$" + coinValue.ToString();

    }
    public void SubtractCoin1() //coin----
    {
        // Subtract specified amount from coinValue when button is clicked
        if (coinValue >= CannonAmount)
        {
            coinValue -= CannonAmount;
            UpdateCoinText(); // Update text after subtracting

            // Check if turret should be disabled after subtraction
            if (coinValue < 40)
            {
                turret1.SetActive(false);
            }  
            if (coinValue < 70)
            {
                turret2.SetActive(false);
            }
             if (coinValue < 110)
            {
                turret3.SetActive(false);
            }


        }
        else
        {
            Debug.Log("Insufficient funds!");
        }
    }
     public void SubtractCoin2() //coin----
    {
        // Subtract specified amount from coinValue when button is clicked
        if (coinValue >= BarrelAmount)
        {
            coinValue -= BarrelAmount;
            UpdateCoinText(); // Update text after subtracting

            // Check if turret should be disabled after subtraction
            
            if (coinValue < 40)
            {
                turret1.SetActive(false);
            }  
            if (coinValue < 70)
            {
                turret2.SetActive(false);
            }
             if (coinValue < 110)
            {
                turret3.SetActive(false);
            }
          

        }
        else
        {
            Debug.Log("Insufficient funds!");
        }
    }
     public void SubtractCoin3() //coin----
    {
        // Subtract specified amount from coinValue when button is clicked
        if (coinValue >= ArtillerylAmount)
        {
            coinValue -= ArtillerylAmount;
            UpdateCoinText(); // Update text after subtracting

          
           if (coinValue < 40)
            {
                turret1.SetActive(false);
            }  
            if (coinValue < 70)
            {
                turret2.SetActive(false);
            }
             if (coinValue < 110)
            {
                turret3.SetActive(false);
            }

        }
        else
        {
            Debug.Log("Insufficient funds!");
        }
    }

    

   
    // Method to stop the timer and perform necessary actions
   /* private void StopTimer()
    {
        timerActive = false;   // Stop the countdown 
        turret1.SetActive(true);   // Activate button1 when countdown reaches zero
        timerUI.SetActive(false);  // Hide the timer UI
        countdown = timeBetweenWaves;  // Reset countdown for the next wave
        UpdateTimerUI();   // Update timer UI to display the reset countdown value
        SubtractCoin(); 
    }*/
   

    // Coroutine to handle turret spawning (currently not used in this version)
   /*private IEnumerator SpawnTurret()
    {
        // Assuming you have a method to get the turret you want to build

        // Wait for a short delay before setting the turret to build
        yield return new WaitForSeconds(0f);

        // Set the turret to build
        button1.SetActive(true);
        timerUI.SetActive(false);
    }*/
}
