using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private ParticleController particleController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null)
        {
            if(collision.gameObject.CompareTag("Platform"))
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
            if (collision.gameObject.CompareTag("Ground"))
            {
                particleController.PlayFallParticle();
                particleController.PlayMovParticle();
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision != null)
        {
            if (collision.gameObject.CompareTag("Platform"))
            {
                PlayerController.Instance.isGrounded = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision != null)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                particleController.StopMovParticle();
            }
        }
    }
}
