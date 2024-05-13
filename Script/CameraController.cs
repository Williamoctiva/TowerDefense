



using UnityEngine;
using UnityEngine.UI;

public class ToggleObjects : MonoBehaviour
{
     AudioMAnager audiomanager;
    public GameObject Camera1; //Camera1
    public GameObject Camera2; //Camera2
    public Button toggleButton; // Assign in the Inspector

    private bool isGameObject1Active = false;

    
    private void Awake(){
        //audiomanager = GameObject.FindGameObjectsWithTag("audio").GetComponent<AudioMAnager>();
        audiomanager = FindObjectOfType<AudioMAnager>();
    }
    void Start()
    {
        // Ensure the button is connected to the click event
        toggleButton.onClick.AddListener(ToggleGameObjects);
    }

    void ToggleGameObjects()
    {
        audiomanager.PlaySFX(audiomanager.click);
        // Toggle the active state of GameObject1 and GameObject2
        isGameObject1Active = !isGameObject1Active;

        Camera1.SetActive(isGameObject1Active);
        Camera2.SetActive(!isGameObject1Active);
    }
}
