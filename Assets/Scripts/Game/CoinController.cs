using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetTriggerCollecting()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.pickUpCoin);
        animator.SetTrigger("Collecting");
    }

    public void Destroy()
    {
        GameManager.Instance.coinCounter += 1;
        Destroy(gameObject);
    }
}
