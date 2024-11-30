using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemsController : MonoBehaviour
{
    [SerializeField] PlatformSpawner pSpawner;
    [SerializeField] EnemySpawner eSpawner;

    [SerializeField] Button targetBtn;
    [SerializeField] Color disabledColor;
    [SerializeField] Color normalColor;

    public TextMeshProUGUI counter;

    public Data data;

    public float timeToUseItem;

    public bool isClicked = false;

    private void Awake()
    {
        string loadedData = SaveSystem.Load("save");
        if (loadedData != null)
        {
            data = JsonUtility.FromJson<Data>(loadedData);
        }
        else
        {
            data = new Data();
        }

        data.currentRespawnItem = 1;
        data.currentRocketItem = 1;

        string saveString = JsonUtility.ToJson(data);

        SaveSystem.Save("save", saveString);
        ChangeButtonState();
    }

    private void Update()
    {
        timeToUseItem += Time.deltaTime;
        if(timeToUseItem > 5f )
        {
            gameObject.SetActive( false );
        }
    }

    public void ChangeButtonState()
    {
        if (gameObject.CompareTag("RocketItem"))
        {
            ChangeRespawnBtnState(data.currentRocketItem);
        }
        else if (gameObject.CompareTag("RespawnItem"))
        {
            ChangeRespawnBtnState(data.currentRespawnItem);
        }
    }

    public void ChangeRespawnBtnState(int currentCount)
    {
        counter.text = "x" + currentCount;
        if (currentCount == 0)
        {
            ChangeButtonColor(false, disabledColor);
        }
        else
        {
            ChangeButtonColor(true, normalColor);
        }
    }

    private void ChangeButtonColor(bool isInteractable, Color targetColor)
    {
        ColorBlock cb = targetBtn.colors;

        cb.disabledColor = targetColor;

        targetBtn.colors = cb;

        targetBtn.interactable = isInteractable;
    }

    public void TriggerBoosted()
    {
        if (data.currentRocketItem > 0)
        {
            data.currentRocketItem--;
            string saveString = JsonUtility.ToJson(data);

            SaveSystem.Save("save", saveString);

            counter.text = "x" + data.currentRocketItem;
            PlayerController.Instance.isBoosted = true;
            pSpawner.canSpawn = false;
            eSpawner.canSpawn = false;
            gameObject.SetActive(false);
        }
    }

    public IEnumerator CRespawn()
    {
        PlayerController.Instance.Respawn();
        yield return StartCoroutine(PlayerController.Instance.Undying());
        gameObject.SetActive(false);
    }

    public void Respawn()
    {
        if (!isClicked && data.currentRespawnItem > 0)
        {
            data.currentRespawnItem--;
            string saveString = JsonUtility.ToJson(data);

            SaveSystem.Save("save", saveString);

            counter.text = "x" + data.currentRespawnItem;
            isClicked = true;
            StartCoroutine(CRespawn());
        }
    }
}
