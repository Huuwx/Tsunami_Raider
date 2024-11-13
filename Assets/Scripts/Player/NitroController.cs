using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NitroController : MonoBehaviour
{
    [SerializeField] private float jumpTimeMax;
    private float jumpTimeCounter;

    [SerializeField] private Image nitroBarFill;

    private void Awake()
    {
        jumpTimeCounter = jumpTimeMax;
    }

    public float getJumpTimeCounter()
    {
        return jumpTimeCounter;
    }

    public void SubtractJumpTime()
    {
        jumpTimeCounter -= Time.deltaTime;

        UpdateNitroBar();
    }

    public void RefillJumpTime()
    {
        if (jumpTimeCounter < jumpTimeMax)
        {
            jumpTimeCounter += Time.deltaTime * 0.6f;
        }
        else
        {
            jumpTimeCounter = jumpTimeMax;
        }

        UpdateNitroBar();
    }

    private void UpdateNitroBar()
    {
        nitroBarFill.fillAmount = jumpTimeCounter / jumpTimeMax;
    }
}
