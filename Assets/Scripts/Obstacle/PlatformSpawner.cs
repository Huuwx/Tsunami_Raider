using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : Spawner
{
    [SerializeField] private GameObject[] platformAppearLater;

    protected override void Spawn()
    {
        base.Spawn();
         if(PlayerController.Instance.acceleration <= 2f)
        {
            foreach(GameObject platform in platformAppearLater) 
            {
                obstaclePrefabs.Add(platform);
            }
        }
    }
}
