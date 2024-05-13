using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Loadingscript : MonoBehaviour
{
    public Slider loadingSlider;
    public float smoothSpeed = 0.5f; // Adjust this to control the speed of the slider movement

    void Start()
    {
        // Hide the loading slider initially
        loadingSlider.gameObject.SetActive(false);
    }

    public void LoadSceneWithLoading()
    {
        // Show the loading screen
        loadingSlider.gameObject.SetActive(true);

        // Start the async operation to load Scene2
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level1");
        asyncLoad.allowSceneActivation = false;

        // Keep looping until the async operation is complete
        while (!asyncLoad.isDone)
        {
            // Calculate the target progress based on scene load progress (0 to 0.9)
            float targetProgress = Mathf.Clamp01(asyncLoad.progress / 0.9f);

            // Smoothly interpolate the slider value towards the target progress
            loadingSlider.value = Mathf.Lerp(loadingSlider.value, targetProgress, smoothSpeed * Time.deltaTime);

            // If the load is almost complete
            if (asyncLoad.progress >= 0.9f)
            {
                // Ensure the slider displays full progress
                loadingSlider.value = 1f;

                // Allow scene activation to complete loading
                asyncLoad.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}

/*using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Loadingscript : MonoBehaviour
{
    public Slider loadingSlider;

    void Start()
    {
        // Hide the loading slider initially
        loadingSlider.gameObject.SetActive(false);
    }

    public void LoadSceneWithLoading()
    {
        // Show the loading screen
        loadingSlider.gameObject.SetActive(true);

        // Start the async operation to load Scene2
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level1");
        asyncLoad.allowSceneActivation = false;

        // Keep looping until the async operation is complete
        while (!asyncLoad.isDone)
        {
            // Calculate the actual progress based on scene load progress (0 to 0.9)
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);

            // Update the loading slider
            loadingSlider.value = progress;

            // If the load is almost complete
            if (asyncLoad.progress >= 0.9f)
            {
                // Ensure the slider displays full progress
                loadingSlider.value = 1f;

                // Allow scene activation to complete loading
                asyncLoad.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}*/

/*using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class Loadingscript : MonoBehaviour
{
    public Slider loadingSlider;

    void Start()
    {
        // Hide the loading slider initially
        loadingSlider.gameObject.SetActive(false);
    }

    public void LoadSceneWithLoading()
    {
        // Show the loading screen
        loadingSlider.gameObject.SetActive(true);

        // Start the async operation to load Scene2
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level1");
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            // Update the loading slider based on the progress
            loadingSlider.value = asyncLoad.progress;

            // Check if the load is almost done (progress = 0.9 is almost complete)
            if (asyncLoad.progress >= 0.9f)
            {
                // Complete the loading and activate the scene
                asyncLoad.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}*/

