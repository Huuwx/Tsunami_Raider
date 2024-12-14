using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private Animator animator;


    private void Start()
    {
        gameManager = GameObject.Find("DataManager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();
    }

    public void SetTriggerCollecting()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.pickUpCoin);
        animator.SetTrigger("Collecting");
    }

    public void Destroy()
    {
        gameManager.coinCounter += 1;
        Destroy(gameObject);
    }
}
