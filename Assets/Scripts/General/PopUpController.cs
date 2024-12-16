using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpController : MonoBehaviour
{
    [SerializeField] private GameObject settingPopUp;
    [SerializeField] private GameObject quitPopUp;

    public void OSettingPopUp()
    {
        settingPopUp.SetActive(true);
    }

    public void ClPopUp()
    {
        if (GameObject.Find("Popup_Setting") != null)
        {
            settingPopUp.SetActive(false);
        }
        else if (GameObject.Find("Popup_Quit") != null)
        {
            quitPopUp.SetActive(false);
        }
        else if (GameObject.Find("Popup"))
        {
            LoadSceneController.Instance.LoadScene("HomeScene");
        }
    }

    public void OExitPopUp()
    {
        quitPopUp.SetActive(true);
    }
}
