using UnityEngine;
using UnityEngine.UI;

public class InputData : MonoBehaviour
{
    public Canvas usernameCanvas;
    public InputField usernameInputField;
    public Text usernameText;
    public Text CaptainText;

    private void Start()
    {
        // Ensure canvas is disabled at the start
        if (usernameCanvas != null)
            usernameCanvas.enabled = false;

        // Load the username from PlayerPrefs
        string savedUsername = PlayerPrefs.GetString("PlayerUsername", "Player");
        usernameText.text = savedUsername;
    }

    public void EnableUsernameCanvas()
    {
        // Enable the canvas for editing the username
        if (usernameCanvas != null)
            usernameCanvas.enabled = true;

        // Set the input field text to the current username
        if (usernameInputField != null)
            usernameInputField.text = usernameText.text;
    }

    public void SaveUsername()
    {
        // Save the username to PlayerPrefs
        if (usernameInputField != null)
        {
            string newUsername = usernameInputField.text;

            // Update the displayed username
            usernameText.text = newUsername;

            // Save the new username to PlayerPrefs
            PlayerPrefs.SetString("PlayerUsername", newUsername);
            PlayerPrefs.Save(); // Save PlayerPrefs to disk

            Debug.Log("Username saved: " + newUsername);
        }

        // Disable the canvas after saving
        if (usernameCanvas != null)
            usernameCanvas.enabled = false;
    }
    public void Captain(){
        CaptainText.text = "Hello Captain " +  usernameText.text + ", help us liberate our planet! Lets Start the mission";
    }

}
/*
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputData : MonoBehaviour
{
    public Canvas usernameCanvas;
    public InputField usernameInputField;
    public Text usernameText;
    public Text CaptainText;
    public float fadeDuration = 1f; // Duration of fade animation in seconds

    private CanvasGroup canvasGroup;

    private void Start()
    {
        // Ensure canvas is disabled at the start
        if (usernameCanvas != null)
            usernameCanvas.enabled = false;

        // Load the username from PlayerPrefs
        string savedUsername = PlayerPrefs.GetString("PlayerUsername", "Player");
        usernameText.text = savedUsername;

        // Get the CanvasGroup component
        canvasGroup = usernameText.GetComponent<CanvasGroup>();
    }

    public void EnableUsernameCanvas()
    {
        // Enable the canvas for editing the username
        if (usernameCanvas != null)
            usernameCanvas.enabled = true;

        // Set the input field text to the current username
        if (usernameInputField != null)
            usernameInputField.text = usernameText.text;
    }

    public void SaveUsername()
    {
        // Save the username to PlayerPrefs
        if (usernameInputField != null)
        {
            string newUsername = usernameInputField.text;

            // Update the displayed username
            usernameText.text = newUsername;

            // Save the new username to PlayerPrefs
            PlayerPrefs.SetString("PlayerUsername", newUsername);
            PlayerPrefs.Save(); // Save PlayerPrefs to disk

            Debug.Log("Username saved: " + newUsername);
        }

        // Disable the canvas after saving
        if (usernameCanvas != null)
            usernameCanvas.enabled = false;
    }

    public void Captain()
    {
        StartCoroutine(ShowCaptainMessage());
    }

    private IEnumerator ShowCaptainMessage()
    {
        // If canvas is not already enabled, fade in the text
        if (!usernameCanvas.enabled)
        {
            // Fade out the text
            StartCoroutine(FadeTextOut());

            // Wait for the fade to complete
            yield return new WaitForSeconds(fadeDuration);
        }

        // Show Captain message
        CaptainText.text = "Hello Captain " + usernameText.text + ", help us liberate our planet! Let's start the mission";

        // Immediately show the text by enabling the canvas
        if (usernameCanvas != null)
            usernameCanvas.enabled = true;
    }

    private IEnumerator FadeTextOut()
    {
        float timer = 0f;
        while (timer < fadeDuration)
        {
            // Reduce the alpha of the CanvasGroup to fade out
            canvasGroup.alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            timer += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = 0f; // Ensure text is fully faded out
    }
}*/

