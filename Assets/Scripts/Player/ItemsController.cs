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

    public float timeToUseItem;

    public bool isClicked = false;

    private void Awake()
    {
        ChangeBtnState(GameManager.Instance.data.currentRocketItem);
    }

    private void Update()
    {
        timeToUseItem += Time.deltaTime;
        if(timeToUseItem > 5f )
        {
            gameObject.SetActive( false );
        }
    }

    public void ChangeBtnState(int currentCount)
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
        if (GameManager.Instance.data.currentRocketItem > 0)
        {
            GameManager.Instance.data.currentRocketItem--;

            GameManager.Instance.SaveData();

            counter.text = "x" + GameManager.Instance.data.currentRocketItem;

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
        if (!isClicked && GameManager.Instance.data.currentRespawnItem > 0)
        {
            GameManager.Instance.data.currentRespawnItem--;
            
            GameManager.Instance.SaveData();

            counter.text = "x" + GameManager.Instance.data.currentRespawnItem;
            isClicked = true;
            StartCoroutine(CRespawn());
        }
    }
}
