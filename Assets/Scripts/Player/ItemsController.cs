using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemsController : MonoBehaviour
{
    private static ItemsController instance;

    public static ItemsController Instance { get { return instance; } }

    [SerializeField] PlatformSpawner pSpawner;
    [SerializeField] EnemySpawner eSpawner;

    [SerializeField] private GameObject respawnItem;
    [SerializeField] private GameObject rocketItem;

    public TextMeshProUGUI counter;

    public float timeToUseItem;

    public bool isClicked = false;
    public bool isDead = false;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        timeToUseItem += Time.deltaTime;
        if(timeToUseItem > 5f )
        {
            rocketItem.SetActive( false );
            respawnItem.SetActive( false );
            if(isDead == true )
            {
                SoundController.Instance.PlayOneShot(SoundController.Instance.gameoverSound);
                UIController.Instance.GameOver();
            }
        }
    }

    public void TriggerBoosted()
    {
        if (GameManager.Instance.data.getCurrentRocketItem() > 0)
        {
            int currentRocketItem = GameManager.Instance.data.getCurrentRocketItem();

            GameManager.Instance.data.setCurrentRocketItem(currentRocketItem -= 1);

            GameManager.Instance.SaveData();

            UseItemBtnController useItemBtnController = rocketItem.GetComponent<UseItemBtnController>();

            useItemBtnController.counter.text = "x" + GameManager.Instance.data.getCurrentRocketItem();

            SoundController.Instance.PlayOneShot(SoundController.Instance.rocket);
            PlayerController.Instance.isBoosted = true;
            pSpawner.canSpawn = false;
            eSpawner.canSpawn = false;
            rocketItem.SetActive(false);
        }
    }

    public IEnumerator CRespawn()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.respawnSound);
        isDead = false;
        PlayerController.Instance.Respawn();
        yield return StartCoroutine(PlayerController.Instance.Undying());
        respawnItem.SetActive(false );
    }

    public void Respawn()
    {
        if (!isClicked && GameManager.Instance.data.getCurrentRespawnItem() > 0)
        {
            int currentRespawnItem = GameManager.Instance.data.getCurrentRespawnItem();

            GameManager.Instance.data.setCurrentRespawnItem(currentRespawnItem -= 1);
            
            GameManager.Instance.SaveData();

            UseItemBtnController useItemBtnController = respawnItem.GetComponent<UseItemBtnController>();

            useItemBtnController.counter.text = "x" + GameManager.Instance.data.getCurrentRespawnItem();
            isClicked = true;
            StartCoroutine(CRespawn());
        }
    }
}
