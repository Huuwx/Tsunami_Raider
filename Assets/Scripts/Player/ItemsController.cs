using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    [SerializeField] PlatformSpawner pSpawner;
    [SerializeField] EnemySpawner eSpawner;

    public float timeToUseItem;

    public bool isClicked = false;

    private void Update()
    {
        timeToUseItem += Time.deltaTime;
        if(timeToUseItem > 5f )
        {
            gameObject.SetActive( false );
        }
    }

    public void TriggerBoosted()
    {
        PlayerController.Instance.isBoosted = true;
        pSpawner.canSpawn = false;
        eSpawner.canSpawn = false;
        gameObject.SetActive( false );
    }

    public IEnumerator CRespawn()
    {
        PlayerController.Instance.Respawn();
        yield return StartCoroutine(PlayerController.Instance.Undying());
        gameObject.SetActive(false);
    }

    public void Respawn()
    {
        if (!isClicked)
        {
            isClicked = true;
            StartCoroutine(CRespawn());
        }
    }
}
