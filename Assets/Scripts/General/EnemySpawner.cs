using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    protected override void SpawnLoob()
    {
        base.SpawnLoob();
        if (PlayerController.Instance.acceleration <= 0.5f && PlayerController.Instance.isGrounded == true)
        {
            if (plusTimeSpawner > 1.25f)
            {
                plusTimeSpawner -= PlayerController.Instance.acceleration * Time.deltaTime;
            }
            else
            {
                plusTimeSpawner = 1.25f;
            }
        }
    }
}
