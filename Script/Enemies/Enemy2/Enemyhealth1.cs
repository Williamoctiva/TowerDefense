using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemyhealth1 : MonoBehaviour
{
    AudioMAnager audiomanager;
    public Slider healthSlider; // Reference to the UI Slider for health
    public float maxHealth = 100; // Maximum health value
    private float currentHealth; // Current health value
    
    public float barreldamageAmount = 1f; // Amount of health to subtract when triggered
    public float cannondamageAmount = 10f;
    public float artillerydamageAmount = 50f;
    
    private void Awake(){
        //audiomanager = GameObject.FindGameObjectsWithTag("audio").GetComponent<AudioMAnager>();
        audiomanager = FindObjectOfType<AudioMAnager>();
    }
    void Start()
    {
        currentHealth = maxHealth;
        
        UpdateHealthUI();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet1")) //cannon
        {
            SubtractHealth1();
            UpdateHealthUI();
        
        }
        if (other.CompareTag("Bullet2")) //Barrel
        {
            SubtractHealth2();
            UpdateHealthUI();
        
        }
        if (other.CompareTag("Bullet3")) // Artillery
        {
            SubtractHealth3();
            UpdateHealthUI();
        
        }
    }

    private void SubtractHealth1()
    {
        currentHealth -= cannondamageAmount;
        
        
       currentHealth = Mathf.Max(currentHealth, 0f); // Ensure health doesn't go below zero
     
        
        if(currentHealth <= 0){
            audiomanager.PlaySFX1(audiomanager.enemydeath);
            Destroy(gameObject);
        }

        // You can add more logic here, like checking if health reaches zero and triggering events accordingly.
    }

     private void SubtractHealth2()
    {
         currentHealth -= barreldamageAmount;
        
        
       currentHealth = Mathf.Max(currentHealth, 0f); // Ensure health doesn't go below zero
     
        
        if(currentHealth <= 0){
            audiomanager.PlaySFX1(audiomanager.enemydeath);
            Destroy(gameObject);
        }

        // You can add more logic here, like checking if health reaches zero and triggering events accordingly.
    }

     private void SubtractHealth3()
    {
       currentHealth -= artillerydamageAmount;
        
        
       currentHealth = Mathf.Max(currentHealth, 0f); // Ensure health doesn't go below zero
     
        
        if(currentHealth <= 0){
            audiomanager.PlaySFX1(audiomanager.enemydeath);
            Destroy(gameObject);
        }
        

        // You can add more logic here, like checking if health reaches zero and triggering events accordingly.
    }

    private void UpdateHealthUI()
    {
        // Update the Slider UI value to reflect the current health
         // healthSlider.value = currentHealth1 / maxHealth;
          healthSlider.value = currentHealth / maxHealth;
          //healthSlider.value = currentHealth3 / maxHealth;
    }
}