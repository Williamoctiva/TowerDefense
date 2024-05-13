using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWarning : MonoBehaviour
{
  public GameObject cannontext;
  public GameObject barreltext;
  public GameObject artillerytext;
  public GameObject removetext;

  public void CannonText(){
    cannontext.SetActive(true);
    barreltext.SetActive(false);
    artillerytext.SetActive(false);
    removetext.SetActive(false);
  }
  public void BarrelText(){
    cannontext.SetActive(false);
    barreltext.SetActive(true);
    artillerytext.SetActive(false);
    removetext.SetActive(false);
  }
  public void ArtilleryText(){
    cannontext.SetActive(false);
    barreltext.SetActive(false);
    artillerytext.SetActive(true);
    removetext.SetActive(false);
  }
  public void RemoveText(){
    cannontext.SetActive(false);
    barreltext.SetActive(false);
    artillerytext.SetActive(false);
    removetext.SetActive(true);
  }

}
