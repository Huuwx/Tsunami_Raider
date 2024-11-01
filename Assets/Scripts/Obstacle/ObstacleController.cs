using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    protected Rigidbody2D rb;

    public Rigidbody2D getRb() { return rb; }

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    protected virtual void Update()
    {
        HandleSpeed();
        DestroyObstacle();
    }

    private void DestroyObstacle()
    {
        if(transform.position.x <= -40)
        {
            Destroy(gameObject);
        }
    }

    private void HandleSpeed()
    {
        rb.velocity = Vector2.left * (PlayerController.Instance.speed / 8);  
    }
}
