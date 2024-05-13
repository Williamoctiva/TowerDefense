using UnityEngine;

public class Victory2 : MonoBehaviour
{
    public GameObject Boss;
    public GameObject VictoryUI;
   
    
    void Start(){
        Time.timeScale = 1;
    } 
    void Update()
    {
        // Check if Boss GameObject is destroyed
        if (Boss == null || !Boss.activeSelf)
        {
            // Set VictoryUI to active when Boss is destroyed or inactive
            VictoryUI.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
    

}
