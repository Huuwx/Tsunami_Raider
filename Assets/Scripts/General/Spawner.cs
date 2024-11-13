﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;

    public float plusTimeSpawner;
    public float obstacleSpawnTime;

    [SerializeField] private float timeUntilObstacleSpawn;

    protected virtual void Awake()
    {
        timeUntilObstacleSpawn = 0f;
    }

    protected virtual void Update()
    {
        SpawnLoob();
    }

    protected virtual void SpawnLoob()
    {
        obstacleSpawnTime = PlayerController.Instance.acceleration + plusTimeSpawner; // Giam thoi gian spawn dua tren gia toc

        timeUntilObstacleSpawn += Time.deltaTime;

        if(timeUntilObstacleSpawn > obstacleSpawnTime)
        {
            Spawn();
            timeUntilObstacleSpawn = 0f;
        }
    }

    private void Spawn()
    {
        GameObject obstacleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];

        GameObject spawnedObstacle = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity);
    }
}
