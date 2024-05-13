

/*using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
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
            UnlockedNewlevel();
            // Set VictoryUI to active when Boss is destroyed or inactive
            VictoryUI.SetActive(true);
            Time.timeScale = 0;
            
        }

    }
    void UnlockedNewlevel(){
        PlayerPrefs.SetInt("UnlockedLevel6", PlayerPrefs.GetInt("UnlockedLevel6",1)+1);
        PlayerPrefs.Save();
     }
   
}*/


/*
void UnlockedNewlevel()
{
    int currentUnlockedLevel = PlayerPrefs.GetInt("UnlockedLevel1", 2);

    // Increment unlocked level by 1 if it's less than the total number of buttons
    if (currentUnlockedLevel < lvlbuttons.Length + 1)
    {
        currentUnlockedLevel++; // Increment unlocked level
        PlayerPrefs.SetInt("UnlockedLevel1", currentUnlockedLevel);
        PlayerPrefs.Save();
    }
}
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameObject Boss;
    public GameObject VictoryUI;

    private bool levelUnlocked = false;  // Flag to track if level is already unlocked

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        // Check if Boss GameObject is destroyed
        if (Boss == null || !Boss.activeSelf)
        {
            // Check if the level is already unlocked to prevent multiple unlocks
            if (!levelUnlocked)
            {
                UnlockedNewlevel();
                levelUnlocked = true;  // Mark level as unlocked
            }

            // Set VictoryUI to active when Boss is destroyed or inactive
            VictoryUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void UnlockedNewlevel()
    {
        // Assuming you are unlocking a specific level index (e.g., Level 6)
        int currentUnlockedLevel = PlayerPrefs.GetInt("UnlockedLevel8", 2);
        // Increment the unlocked level by 1
        PlayerPrefs.SetInt("UnlockedLevel8", currentUnlockedLevel + 1);
        PlayerPrefs.Save();
    }
}


