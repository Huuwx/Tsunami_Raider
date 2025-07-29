using System;
using System.Collections;
using System.Collections.Generic;
using BrunoMikoski.AnimationSequencer;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum MyEnum
{
    SettingPopUp,
    QuitPopUp,
    AchievementPopUp,
}
public class PopUpController : MonoBehaviour
{
    // [SerializeField] private GameObject settingPopUp;
    // [SerializeField] private GameObject quitPopUp;

    [SerializeField] private AnimationSequencerController openSequencer; // "To"
    [SerializeField] private AnimationSequencerController closeSequencer; // "From"

    public void OpenPopUp()
    {
        //settingPopUp.SetActive(true);
        openSequencer.Play();
    }

    public void ClPopUp()
    {
        // if (GameObject.Find("Popup_Setting") != null)
        // {
        //     settingPopUp.SetActive(false);
        // }
        // else if (GameObject.Find("Popup_Quit") != null)
        // {
        //     quitPopUp.SetActive(false);
        // }
        // else if (GameObject.Find("Popup"))
        // {
        //     LoadSceneController.Instance.LoadScene("HomeScene");
        // }
        
        closeSequencer.Play();
    }

    // public void OExitPopUp()
    // {
    //     quitPopUp.SetActive(true);
    // }
}
