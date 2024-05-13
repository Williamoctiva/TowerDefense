using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
     AudioMAnager audiomanager;

    public GameObject pausePanel;
    // Start is called before the first frame update

     private void Awake(){
        //audiomanager = GameObject.FindGameObjectsWithTag("audio").GetComponent<AudioMAnager>();
        audiomanager = FindObjectOfType<AudioMAnager>();
    }
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void Paused()
    {
        audiomanager.PlaySFX(audiomanager.pause);
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
     public void Resume()
    {
        audiomanager.PlaySFX(audiomanager.click);
        Time.timeScale = 1;
         pausePanel.SetActive(false);
    }
    


}
