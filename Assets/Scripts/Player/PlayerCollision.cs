using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null)
        {
            if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
            {
                PlayerController.Instance.isGrounded = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
                Debug.Log("chet");
            }
            if (collision.gameObject.CompareTag("Coin"))
            {
                collision.gameObject.GetComponent<CoinController>().SetTriggerCollecting();
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision != null)
        {
            if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
            {
                PlayerController.Instance.isGrounded = false;
            }
        }
    }
}
