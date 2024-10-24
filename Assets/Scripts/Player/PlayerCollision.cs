using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null)
        {
            if(collision.gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
                Debug.Log("Chet");
            }
            else if(collision.gameObject.CompareTag("Ground"))
            {
                PlayerController.Instance.isGrounded = true;
            }
        }
    }
}
