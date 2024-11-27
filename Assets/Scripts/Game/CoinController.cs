using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private GameManager gameManager;

    private Animator animator;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();
    }

    public void SetTriggerCollecting()
    {
        animator.SetTrigger("Collecting");
    }

    public void Destroy()
    {
        gameManager.coinCounter += 1;
        Destroy(gameObject);
    }
}
