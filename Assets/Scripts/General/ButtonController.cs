using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private static ButtonController instance;

    public static ButtonController Instance { get { return instance; } }

    [SerializeField] private PopUpController settingPopUpController;
    [SerializeField] private PopUpController quitPopUpController;
    [SerializeField] private PopUpController achievementPopUpController;

    private void Awake()
    {
        instance = this;
    }

    public void Pause()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        Time.timeScale = 0;
        UIController.Instance.SetActivePausePanel(true);
    }

    public void ReplayBtn()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        Time.timeScale = 1;
        if (GameObject.Find("GameOver Popup") != false)
        {
            Animator GOanimator = GameObject.Find("GameOver Popup").GetComponent<Animator>();
            GOanimator.SetBool("PopUp", false);
        }
        else if (GameObject.Find("Pause Popup") != false)
        {
            LoadSceneReplay();
        }
    }

    public void ContinueBtn()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        UIController.Instance.SetActivePausePanel(false);
        Time.timeScale = 1;
    }

    public void HomeBtn()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        LoadSceneController.Instance.LoadScene("HomeScene");
        Time.timeScale = 1;
    }

    public void ItemShopBtn()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        LoadSceneController.Instance.LoadScene("ItemShopScene");
    }

    public void ShopSCScene()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        LoadSceneController.Instance.LoadScene("Ship&CharacterShopScene");
    }

    public void LoadSceneReplay()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        LoadSceneController.Instance.LoadScene("SampleScene");
    }

    public void StartGame()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        LoadSceneController.Instance.LoadScene("SampleScene");
    }

    public void OpenSettingPopUp()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        settingPopUpController.OpenPopUp();
        //Animator Sanimator = GameObject.Find("Popup").GetComponent<Animator>();
        //Sanimator.SetBool("OPopUp", true);
        //VolumeSetting.Instance.LoadSlider();
    }

    public void OpenQuitPopUp()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        quitPopUpController.OpenPopUp();
        //Animator Sanimator = GameObject.Find("Popup").GetComponent<Animator>();
        //Sanimator.SetBool("OPopUp", true);
    }

    public void CloseSettingPopUp()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        settingPopUpController.ClPopUp();
        //Animator animator = GameObject.Find("Popup").GetComponent<Animator>();
        //animator.SetBool("OPopUp", false);
    }
    
    public void CloseQuitPopUp()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        quitPopUpController.ClPopUp();
        //Animator animator = GameObject.Find("Popup").GetComponent<Animator>();
        //animator.SetBool("OPopUp", false);
    }
    
    public void CloseAchievementPopUp()
    {
        //SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        achievementPopUpController.ClPopUp();
        //Animator Sanimator = GameObject.Find("Popup").GetComponent<Animator>();
        //Sanimator.SetBool("OPopUp", true);
    }

    public void OpenAchievementScene()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        LoadSceneController.Instance.LoadScene("AchievementScene");
    }

    public void ExitGame()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        Application.Quit();
    }
}
