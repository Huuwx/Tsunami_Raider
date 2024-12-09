using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private static ButtonController instance;

    public static ButtonController Instance { get { return instance; } }

    [SerializeField] private PopUpController popUpController;

    private void Awake()
    {
        instance = this;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        UIController.Instance.SetActivePausePanel(true);
    }

    public void ReplayBtn()
    {
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
        UIController.Instance.SetActivePausePanel(false);
        Time.timeScale = 1;
    }

    public void HomeBtn()
    {
        SceneManager.LoadScene("HomeScene");
        Time.timeScale = 1;
    }

    public void ItemShopBtn()
    {
        SceneManager.LoadScene("ItemShopScene");
    }

    public void LoadSceneReplay()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenSettingPopUp()
    {
        popUpController.OSettingPopUp();
        Animator Sanimator = GameObject.Find("Popup").GetComponent<Animator>();
        Sanimator.SetBool("OPopUp", true);
    }

    public void OpenQuitPopUp()
    {
        popUpController.OExitPopUp();
        Animator Sanimator = GameObject.Find("Popup").GetComponent<Animator>();
        Sanimator.SetBool("OPopUp", true);
    }

    public void ClosePopUp()
    {
        Animator animator = GameObject.Find("Popup").GetComponent<Animator>();
        animator.SetBool("OPopUp", false);
    }

    public void OpenAchievementScene()
    {
        SceneManager.LoadScene("AchievementScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
