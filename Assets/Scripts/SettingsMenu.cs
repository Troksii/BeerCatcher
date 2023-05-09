using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip collectSfx;
    

    void Start ()
    {

    }
    public void SetVolumeMaster (float volume)
    {
        audioMixer.SetFloat("effectsVolume", volume);
        audioSource.PlayOneShot(collectSfx);
    }

    public void SetVolumeMusic (float volume)
    {
        audioMixer.SetFloat("musicVolume", volume);
    }
    
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
