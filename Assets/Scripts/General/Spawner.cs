﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;

    public float obstacleSpawnTime = 15f;
    public float obstacleSpeed = 1f;

    [SerializeField] private float timeUntilObstacleSpawn;

    private void Awake()
    {
        timeUntilObstacleSpawn = 0f;
    }

    private void Update()
    {
        SpawnLoob();
    }

    private void SpawnLoob()
    {
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

        //Rigidbody2D obstacleRB = spawnedObstacle.GetComponent<Rigidbody2D>();
        //obstacleRB.velocity = Vector2.left * obstacleSpeed;
    }
}
