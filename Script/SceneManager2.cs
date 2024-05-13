using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour
{
   
   public void LoadingLevel(){
   
       SceneManager.LoadScene("Loading");
        
   }

   public void ExitGame(){
   
    SceneManager.LoadScene("MainMenu");
    
   }
   public void Retry(){
    
    SceneManager.LoadScene("Level1");
    
   }
   public void NewGame(){
        PlayerPrefs.SetInt("UnlockedLevel8", 2);
        SceneManager.LoadScene("Loading");
        
   }
   public void QuitGameFunction()
    {
        Debug.Log("Quitting the game...");
        
        // This will only work in a built application, not in the Unity Editor
        Application.Quit();
    }

   
   

}
