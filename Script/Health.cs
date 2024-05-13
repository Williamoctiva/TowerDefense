using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthSlider; // Reference to the UI Slider for health
    public float maxHealth = 100; // Maximum health value
     private float currentHealth; // Current health value
     public GameObject gamecanva;

    public float damageAmount = 50f; // Amount of health to subtract when triggered

    public void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
        Time.timeScale = 1;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) // Assuming the other object is tagged as "Player"
        {
            SubtractHealth();
            UpdateHealthUI();
        }
    }

    private void SubtractHealth()
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Max(currentHealth, 0f); // Ensure health doesn't go below zero
        

        if(currentHealth <= 0){
            gamecanva.SetActive(true);
            Time.timeScale = 0;
           
        }
        // You can add more logic here, like checking if health reaches zero and triggering events accordingly.
    }

    private void UpdateHealthUI()
    {
        // Update the Slider UI value to reflect the current health
          healthSlider.value = currentHealth / maxHealth;
    }
}
