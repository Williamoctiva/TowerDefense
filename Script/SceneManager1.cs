using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{
     AudioMAnager audiomanager;

    
    public GameObject OverUi; 
     private void Awake(){
        //audiomanager = GameObject.FindGameObjectsWithTag("audio").GetComponent<AudioMAnager>();
        audiomanager = FindObjectOfType<AudioMAnager>();
    }
    private void Start(){
        
        OverUi.SetActive(false);
    }
 
   public void LoadingLevel(){
   audiomanager.PlaySFX(audiomanager.click);
       SceneManager.LoadScene("Loading");
        
   }

   public void ExitGame(){
   audiomanager.PlaySFX(audiomanager.click);
    SceneManager.LoadScene("MainMenu");
   
   }
   public void Retry(){
    audiomanager.PlaySFX(audiomanager.click);
    SceneManager.LoadScene("Level1");
    
   }
   public void Continue(){
    audiomanager.PlaySFX(audiomanager.click);
    SceneManager.LoadScene("Level2");
    
   }
   public void Continue1(){
    audiomanager.PlaySFX(audiomanager.click);
    SceneManager.LoadScene("Level3");
    
   }
}
