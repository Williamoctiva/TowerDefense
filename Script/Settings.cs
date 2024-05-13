using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Toggle audioToggle;
    public AudioMAnager audiomanager;

    void Start()
    {
        // Initialize toggle based on saved preferences (if available)
        audioToggle.isOn = PlayerPrefs.GetInt("AudioEnabled", 1) == 1; // Default is ON (1)

        // Set initial audio state
        SetAudioState(audioToggle.isOn);
    }

    public void ToggleAudio()
    {
        bool isAudioOn = audioToggle.isOn;
        SetAudioState(isAudioOn);
        PlayerPrefs.SetInt("AudioEnabled", isAudioOn ? 1 : 0);
    }

    private void SetAudioState(bool enable)
    {
        // Find all AudioManagers in scenes and update their audio state
        AudioMAnager[] audioManagers = FindObjectsOfType<AudioMAnager>();
        foreach (AudioMAnager manager in audioManagers)
        {
            manager.SetAudioEnabled(enable);
        }
    }
}
