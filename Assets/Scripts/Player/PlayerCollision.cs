using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private ParticleController particleController;
    [SerializeField] private GameObject respawnItem;

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
                PlayerController.Instance.Die();
                respawnItem.SetActive(true);
                ItemsController itemsController = respawnItem.GetComponent<ItemsController>();
                itemsController.isClicked = false;
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
