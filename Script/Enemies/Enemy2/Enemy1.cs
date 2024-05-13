
using UnityEngine;
using UnityEngine.UI;

public class Enemy1 : MonoBehaviour
{
    [Header("MOVEMENT")]
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    public float rotationSpeed;

    /*[Header("HEALTH")]
    public Slider healthSlider; // Reference to the UI Slider for health
    public float maxHealth = 100; // Maximum health value
     private float currentHealth; // Current health value
    
    public float turretdamageAmount = 10f;*/

    void Start(){
        target = Waypoints.points[0];

        /*currentHealth = maxHealth;
        UpdateHealthUI();*/
    }



   void Update(){
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        
         Quaternion rotationToTarget = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationToTarget, rotationSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f){
            GetNextWaypoints();
           
        }
    }
   /* void Update()
{
    Vector3 dir = target.position - transform.position;
    transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    
    if (Vector3.Distance(transform.position, target.position) <= 0.2f)
    {
        GetNextWaypoints();

        // Rotate towards the new target position
        Vector3 newDir = target.position - transform.position;
        if (newDir != Vector3.zero)
        {
            Quaternion rotationToTarget = Quaternion.LookRotation(newDir);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationToTarget, 5 * Time.deltaTime);
        }
    }
}*/






    void GetNextWaypoints(){
      

       if(wavepointIndex >= Waypoints.points.Length - 1){
        Destroy(gameObject);
          return;
       }
        
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void Face(){
        Vector3 dir = Waypoints.points[wavepointIndex].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); 
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the other object is tagged as "Player"
        {
            SubtractHealth();
            UpdateHealthUI();
        }
    }
     private void SubtractHealth()
    {
        currentHealth -= turretdamageAmount;
        currentHealth = Mathf.Max(currentHealth, 0f); // Ensure health doesn't go below zero
       
        if(currentHealth <= 0){
            Destroy(gameObject);
        }

        // You can add more logic here, like checking if health reaches zero and triggering events accordingly.
    }

    private void UpdateHealthUI()
    {
        // Update the Slider UI value to reflect the current health
          healthSlider.value = currentHealth / maxHealth;
    }*/
   
}
