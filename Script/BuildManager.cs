using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    
    void Awake()
    {
        if(instance != null)
        {
          Debug.LogError ("More than One");
          return;
        }
        instance = this;
        
    }

    public GameObject standardTurrentPrefab1;
    public GameObject standardTurrentPrefab2;
    public GameObject standardTurrentPrefab3;

    private GameObject turrentToBuild;
    private bool isTurretRemovalMode = false;
    //public GameObject basta;

    public GameObject GetTurrentToBuild()
    {
       return turrentToBuild;
       
    }

    public void SetTurrentToBuild(GameObject turrent){
       
        turrentToBuild = turrent;
        

    }
     public void SetTurrentToBuild1(GameObject turrent){
       
        turrentToBuild = turrent;
        

    }
     public void SetTurrentToBuild2(GameObject turrent){
       
        turrentToBuild = turrent;
    }

    
    public void SetTurretRemovalMode(bool isEnabled)
    {
        isTurretRemovalMode = isEnabled;
    }

    public bool IsTurretRemovalMode()
    {
        return isTurretRemovalMode;
    }
    
    
}
/*using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject turrentToBuild;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager instance found!");
            return;
        }
        instance = this;
    }

    public bool CanBuild()
    {
        // Check if a turret is currently being built
        return turrentToBuild == null;
    }
    public GameObject standardTurrentPrefab;  //---------------------------------------------

    public void SetTurrentToBuild(GameObject turrentPrefab)
    {
        if (CanBuild())
        {
            turrentToBuild = turrentPrefab;
        }
        else
        {
            Debug.Log("Cannot build another turret right now.");
        }
    }

    public GameObject GetTurrentToBuild()
    {
        return turrentToBuild;
    }

    public void ClearTurrentToBuild()
    {
        turrentToBuild = null;
    }

    // Call this method when the turret is placed or build action is cancelled
    public void TurrentBuiltOrCancelled()
    {
        ClearTurrentToBuild();
    }
}*/

