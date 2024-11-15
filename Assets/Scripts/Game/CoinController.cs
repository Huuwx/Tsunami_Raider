using System.Collections;
using System.Collections.Generic;
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
        animator.SetTrigger("Collecting");
    }

    public void Destroy()
    {
        PlayerController.Instance.coinCounter += 1;
        Destroy(gameObject);
    }
}
