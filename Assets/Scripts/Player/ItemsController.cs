using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    [SerializeField] PlatformSpawner pSpawner;
    [SerializeField] EnemySpawner eSpawner;

    public float timeToUseItem;

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
}
