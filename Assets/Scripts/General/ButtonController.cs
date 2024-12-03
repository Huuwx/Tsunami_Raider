using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private static ButtonController instance;

    public static ButtonController Instance { get { return instance; } }

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

    }

    public void LoadSceneReplay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
