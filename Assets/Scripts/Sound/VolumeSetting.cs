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
        GameManager.Instance.data.setMasterVolume( volume);
        GameManager.Instance.SaveData();
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
        GameManager.Instance.data.setMusicVolume( volume);
        GameManager.Instance.SaveData();
    }

    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        GameManager.Instance.data.setSFXVolume( volume);
        GameManager.Instance.SaveData();
    }

    public void LoadVolume()
    {
        myMixer.SetFloat("Master", Mathf.Log10(GameManager.Instance.data.getmasterVolume()) * 20);
        myMixer.SetFloat("Music", Mathf.Log10(GameManager.Instance.data.getmusicVolume()) * 20);
        myMixer.SetFloat("SFX", Mathf.Log10(GameManager.Instance.data.getsfxVolume()) * 20);
    }

    public void LoadSlider()
    {
        masterSlider = GameObject.Find("MasterSlider").GetComponent<Slider>();
        musicSlider = GameObject.Find("MusicSlider").GetComponent<Slider>();
        SFXSlider = GameObject.Find("SoundSlider").GetComponent<Slider>();
        if (musicSlider != null && SFXSlider != null && masterSlider != null)
        {
            masterSlider.value = GameManager.Instance.data.getmasterVolume();
            musicSlider.value = GameManager.Instance.data.getmusicVolume();
            SFXSlider.value = GameManager.Instance.data.getsfxVolume();
        }
    }
}
