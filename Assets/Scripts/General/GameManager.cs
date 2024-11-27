using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float distance;
    public int coinCounter = 0;

    public Data data;

    private void Start()
    {
        string loadedData = SaveSystem.Load("save");
        if(loadedData != null)
        {
            data = JsonUtility.FromJson<Data>(loadedData);
        }
        else
        {
            data = new Data();
        }

        coinCounter = 0;
        distance = 0;
    }

    public void GainedDistance(float speed)
    {
        distance += speed * Time.deltaTime;
    }

    public void GameOver()
    {
        if (data.highestDistance < distance)
        {
            data.highestDistance = distance;

            string saveString = JsonUtility.ToJson(data);

            SaveSystem.Save("save", saveString);
        }
        Debug.Log("Current Distance: " + Mathf.FloorToInt(distance));
        Debug.Log("Highest Distance: " + Mathf.FloorToInt(data.highestDistance));
    }
}
