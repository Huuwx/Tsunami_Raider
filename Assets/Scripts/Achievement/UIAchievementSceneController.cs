using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIAchievementSceneController : MonoBehaviour
{
    private static UIAchievementSceneController instance;

    public static UIAchievementSceneController Instance { get { return instance; } }

    [SerializeField] TextMeshProUGUI maxDistanceAchivementText;

    void Start()
    {
        instance = this;

        int maxDistance = Mathf.FloorToInt(GameManager.Instance.data.getHighestDistance());
        maxDistanceAchivementText.text = maxDistance.ToString() + 'm';
    }
    
    public void BackToHome()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        LoadSceneController.Instance.LoadScene("HomeScene");
    }
}
