using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        HandleSpeed();
        DestroyObstacle();
    }

    private void DestroyObstacle()
    {
        if(transform.position.x <= -19)
        {
            Destroy(gameObject);
        }
    }

    private void HandleSpeed()
    {
        rb.velocity = Vector2.left * (PlayerController.Instance.speed / 8);  
    }
}
