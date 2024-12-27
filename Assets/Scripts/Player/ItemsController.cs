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
    public bool isDead = false;

    private void Awake()
    {
        ChangeBtnState(GameManager.Instance.data.getCurrentRocketItem());
    }

    private void Update()
    {
        timeToUseItem += Time.deltaTime;
        if(timeToUseItem > 5f )
        {
            gameObject.SetActive( false );
            if(isDead == true )
            {
                SoundController.Instance.PlayOneShot(SoundController.Instance.gameoverSound);
                UIController.Instance.GameOver();
            }
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
        if (GameManager.Instance.data.getCurrentRocketItem() > 0)
        {
            int currentRocketItem = GameManager.Instance.data.getCurrentRocketItem();

            GameManager.Instance.data.setCurrentRocketItem(currentRocketItem -= 1);

            GameManager.Instance.SaveData();

            counter.text = "x" + GameManager.Instance.data.getCurrentRocketItem();

            SoundController.Instance.PlayOneShot(SoundController.Instance.rocket);
            PlayerController.Instance.isBoosted = true;
            pSpawner.canSpawn = false;
            eSpawner.canSpawn = false;
            gameObject.SetActive(false);
        }
    }

    public IEnumerator CRespawn()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.respawnSound);
        isDead = false;
        PlayerController.Instance.Respawn();
        yield return StartCoroutine(PlayerController.Instance.Undying());
        gameObject.SetActive(false);
    }

    public void Respawn()
    {
        if (!isClicked && GameManager.Instance.data.getCurrentRespawnItem() > 0)
        {
            int currentRespawnItem = GameManager.Instance.data.getCurrentRespawnItem();

            GameManager.Instance.data.setCurrentRespawnItem(currentRespawnItem -= 1);
            
            GameManager.Instance.SaveData();

            counter.text = "x" + GameManager.Instance.data.getCurrentRespawnItem();
            isClicked = true;
            StartCoroutine(CRespawn());
        }
    }
}
