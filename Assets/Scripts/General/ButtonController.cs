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
        SceneManager.LoadScene("SampleScene");
    }

    public void ContinueBtn()
    {
        Time.timeScale = 1;
        UIController.Instance.SetActivePausePanel(false);
    }

    public void HomeBtn()
    {

    }
}
