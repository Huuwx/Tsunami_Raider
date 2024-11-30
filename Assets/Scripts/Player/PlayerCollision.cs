using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private ParticleController particleController;
    [SerializeField] private GameObject respawnItem;

    public Data data;

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
                string loadedData = SaveSystem.Load("save");
                if (loadedData != null)
                {
                    data = JsonUtility.FromJson<Data>(loadedData);
                }
                else
                {
                    data = new Data();
                }

                ItemsController itemsController = respawnItem.GetComponent<ItemsController>();
                PlayerController.Instance.DieA();
                itemsController.ChangeRespawnBtnState(data.currentRespawnItem);
                respawnItem.SetActive(true);
                itemsController.isClicked = false;
                itemsController.timeToUseItem = 0;
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
