using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] lvlbuttons;

    void Start(){
        int UnlockedLevel8 = PlayerPrefs.GetInt("UnlockedLevel8",2);
        for(int i = 0; i < lvlbuttons.Length; i++){
                if(i + 2 > UnlockedLevel8)
                lvlbuttons[i].interactable = false;
        }
    }
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] buttons;

    private void Awake()
    {
        // Get the highest unlocked level index from PlayerPrefs
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 2);

        // Ensure unlockedLevel does not exceed the number of buttons
      //  unlockedLevel = Mathf.Min(unlockedLevel, buttons.Length);

        // Disable all buttons by default
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        // Enable buttons up to the unlocked level
        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }
}*/

