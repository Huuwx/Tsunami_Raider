using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    void Update()
    {
        DestroyObstacle();
    }

    private void DestroyObstacle()
    {
        if(transform.position.x <= -19)
        {
            Destroy(gameObject);
        }
    }
}
