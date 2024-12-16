using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    private static VolumeSetting instance;

    public static VolumeSetting Instance { get { return instance; } }

    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider SFXSlider;
    [SerializeField] private Slider masterSlider;

    private void Start()
    {
        instance = this;
        LoadVolume();
    }

    public void SetMasterVolume()
    {
        float volume = masterSlider.value;
        myMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
        GameManager.Instance.data.masterVolume = volume;
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
        GameManager.Instance.data.musicVolume = volume;
    }

    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        GameManager.Instance.data.sfxVolume = volume;
    }

    public void LoadVolume()
    {
        myMixer.SetFloat("Master", Mathf.Log10(GameManager.Instance.data.masterVolume) * 20);
        myMixer.SetFloat("Music", Mathf.Log10(GameManager.Instance.data.musicVolume) * 20);
        myMixer.SetFloat("SFX", Mathf.Log10(GameManager.Instance.data.sfxVolume) * 20);
    }

    public void LoadSlider()
    {
        masterSlider = GameObject.Find("MasterSlider").GetComponent<Slider>();
        musicSlider = GameObject.Find("MusicSlider").GetComponent<Slider>();
        SFXSlider = GameObject.Find("SoundSlider").GetComponent<Slider>();
        if (musicSlider != null && SFXSlider != null && masterSlider != null)
        {
            masterSlider.value = GameManager.Instance.data.masterVolume;
            musicSlider.value = GameManager.Instance.data.musicVolume;
            SFXSlider.value = GameManager.Instance.data.sfxVolume;
        }
    }
}
