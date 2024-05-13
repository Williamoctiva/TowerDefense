using UnityEngine;

public class AudioMAnager : MonoBehaviour
{
    [SerializeField] AudioSource musicsource;
    [SerializeField] AudioSource SFXSOurce;
    [SerializeField] AudioSource SFXCharacters;

    public AudioClip background;
    public AudioClip cannon;
    public AudioClip barrel;
    public AudioClip artillery;
    public AudioClip enemydeath;

    public AudioClip pause;
    public AudioClip click;

    private bool audioEnabled = true;

    private void Start()
    {
        musicsource.clip = background;
        musicsource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        if (audioEnabled)
            SFXSOurce.PlayOneShot(clip);
    }

    public void PlaySFX1(AudioClip clip)
    {
        if (audioEnabled)
            SFXCharacters.PlayOneShot(clip);
    }

    public void SetAudioEnabled(bool enable)
    {
        audioEnabled = enable;

        // Mute or unmute all audio sources
        musicsource.mute = !enable;
        SFXSOurce.mute = !enable;
        SFXCharacters.mute = !enable;
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMAnager : MonoBehaviour
{
   [SerializeField] AudioSource musicsource;
   [SerializeField] AudioSource SFXSOurce;
   [SerializeField] AudioSource SFXCharacters;

   public AudioClip background;
   public AudioClip cannon;
   public AudioClip barrel;
   public AudioClip artillery;
   public AudioClip enemydeath;
   
   public AudioClip pause;
   public AudioClip click;
   
   private void Start(){
      musicsource.clip = background;
      musicsource.Play();
   }

   public void PlaySFX(AudioClip clip){
      SFXSOurce.PlayOneShot(clip);
   }
    public void PlaySFX1(AudioClip clip){
      SFXCharacters.PlayOneShot(clip);
   }
  
}*/
