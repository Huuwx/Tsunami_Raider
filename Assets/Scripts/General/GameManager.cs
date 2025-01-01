using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance { get { return instance; } }

    public float distance = 0;
    public int coinCounter = 0;
    public bool gameOver = false;
    

    public Data data;

    private void Awake()
    {
        instance = this;

        //data.currentRocketItem = 100;
        //data.currentRespawnItem = 100;

        //SaveData();

        string loadedData = SaveSystem.Load("save");
        if(loadedData != null)
        {
            data = JsonUtility.FromJson<Data>(loadedData);
        }
        else
        {
            data = new Data();
        }

        //coinCounter = 0;
        //distance = 0;
        //gameOver = false;
    }

    public void SaveData()
    {
        string saveString = JsonUtility.ToJson(data);

        SaveSystem.Save("save", saveString);
    }

    public void GainedDistance(float speed)
    {
        distance += speed * Time.deltaTime;
    }

    public void GameOver()
    {
        if (data.getHighestDistance() < distance)
        {
            data.setHighestDistance(distance);
        }

        if (!gameOver)
        {
            gameOver = true;
            Animator GOanimator = GameObject.Find("GameOver Popup").GetComponent<Animator>();
            GOanimator.SetBool("PopUp", true);

            int currentCoin = data.getCurrentCoin();

            data.setCurrentCoin(currentCoin += coinCounter);

            SaveData();
        }
    }

    private void OnApplicationQuit()
    {
        SaveData();
    }
}
