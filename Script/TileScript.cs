

using UnityEngine;
using UnityEngine.EventSystems;

public class TileScript : MonoBehaviour
{
    public Color hoverColor;
    public Color cantPantColor;
    public Vector3 positionOffset;
    private GameObject turrent;
    private Renderer rend;
    private Color startColor;

    public GameObject cannon;
    public GameObject barrel;
    public GameObject artelliry;
    public GameObject remove;

    BuildManager buildManager;
    
   void Start(){
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }
    void OnMouseDown(){
      if (buildManager.IsTurretRemovalMode())
        {
            if (turrent != null)
            {
                Destroy(turrent);
                remove.SetActive(false);
                turrent = null;
            }
                
        }
      else {
         
         if (buildManager.GetTurrentToBuild() == null)
               
                return;

            if (turrent != null)
            {
                rend.material.color = Color.red;
                return;
            }

            GameObject turrentToBuild = buildManager.GetTurrentToBuild();
            turrent = Instantiate(turrentToBuild, transform.position, transform.rotation);
            buildManager.SetTurrentToBuild(null);

             cannon.SetActive(false);
                barrel.SetActive(false);
                artelliry.SetActive(false);
      }
      /*if(buildManager.GetTurrentToBuild() == null)

      
       return;
      
      
      if(turrent != null){
         rend.material.color = cantPantColor;  
          
        return;
        }

       
      GameObject turrentToBuild = buildManager.GetTurrentToBuild();
      turrent = (GameObject)Instantiate(turrentToBuild, transform.position + positionOffset, transform.rotation);
      buildManager.SetTurrentToBuild(null);*/
       
    
    }

   void OnMouseEnter(){
     if(EventSystem.current.IsPointerOverGameObject())
    if(buildManager.GetTurrentToBuild() == null)

      return;
     
       rend.material.color = hoverColor;  
    
    
      
   }

      

   void OnMouseExit(){

     rend.material.color = startColor;
       
   }
   
}
