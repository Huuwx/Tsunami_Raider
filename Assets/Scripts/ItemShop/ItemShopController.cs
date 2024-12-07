using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopController : MonoBehaviour
{
    private static ItemShopController instance;

    public static ItemShopController Instance { get { return instance; } }

    private int coin;

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

    public void SaveData()
    {
        string saveString = JsonUtility.ToJson(data);

        SaveSystem.Save("save", saveString);
    }
}
