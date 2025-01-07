using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UseItemBtnController : MonoBehaviour
{
    [SerializeField] Button targetBtn;
    [SerializeField] Color disabledColor;
    [SerializeField] Color normalColor;

    public TextMeshProUGUI counter;

    private void Awake()
    {
        ChangeBtnState(GameManager.Instance.data.getCurrentRocketItem());
    }

    public void ChangeBtnState(int currentCount)
    {
        counter.text = "x" + currentCount;
        if (currentCount == 0)
        {
            ChangeButtonColor(false, disabledColor);
        }
        else
        {
            ChangeButtonColor(true, normalColor);
        }
    }

    private void ChangeButtonColor(bool isInteractable, Color targetColor)
    {
        ColorBlock cb = targetBtn.colors;

        cb.disabledColor = targetColor;

        targetBtn.colors = cb;

        targetBtn.interactable = isInteractable;
    }
}
