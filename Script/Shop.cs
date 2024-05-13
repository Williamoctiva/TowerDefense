
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
   AudioMAnager audiomanager;
     
    BuildManager buildManager;

    private void Awake(){
        //audiomanager = GameObject.FindGameObjectsWithTag("audio").GetComponent<AudioMAnager>();
        audiomanager = FindObjectOfType<AudioMAnager>();
    }

    void Start(){
       buildManager = BuildManager.instance;
    }
    public void PurChaseStandardTurrent (){
       audiomanager.PlaySFX(audiomanager.click);
        Debug.Log("Naol Pogi");
        buildManager.SetTurrentToBuild(buildManager.standardTurrentPrefab1);
        buildManager.SetTurretRemovalMode(false);
        //------------------------------------------------------------
       

    }
     public void PurChaseStandardTurrent1 (){
       audiomanager.PlaySFX(audiomanager.click);
        Debug.Log("Naol Pogi");
        buildManager.SetTurrentToBuild1(buildManager.standardTurrentPrefab2);
        buildManager.SetTurretRemovalMode(false);
        //------------------------------------------------------------
       

    }
     public void PurChaseStandardTurrent2 (){
       audiomanager.PlaySFX(audiomanager.click);
        Debug.Log("Naol Pogi");
        buildManager.SetTurrentToBuild2(buildManager.standardTurrentPrefab3);
        buildManager.SetTurretRemovalMode(false);
        //------------------------------------------------------------
       

    }
    public void EnableTurretRemoval()
     {
       audiomanager.PlaySFX(audiomanager.click);
        buildManager.SetTurretRemovalMode(true);
     } 

}
