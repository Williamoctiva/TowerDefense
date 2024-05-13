using System.Collections;
using UnityEngine;


public class Timer : MonoBehaviour
{
   public GameObject toLevel1;
    public GameObject toLevel2;
     public GameObject toLevel3;

   public void ToLevel1(){
    toLevel1.SetActive(true);
   }
    public void ToLevel2(){
    toLevel2.SetActive(true);
   }
    public void ToLevel3(){
    toLevel3.SetActive(true);
   }
}