using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementController : MonoBehaviour
{
    private static AchievementController instance;

    public static AchievementController Instance { get { return instance; } }

    public Data data;

    void Awake()
    {
        instance = this;

        string loadedData = SaveSystem.Load("save");
        if (loadedData != null)
        {
            data = JsonUtility.FromJson<Data>(loadedData);
        }
        else
        {
            data = new Data();
        }
    }
}
