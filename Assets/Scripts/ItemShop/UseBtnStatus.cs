using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseBtnStatus : MonoBehaviour
{
    [SerializeField] Button targetBtn;
    [SerializeField] Color disabledColor;
    [SerializeField] Color normalColor;

    public void SetDisableColor()
    {
        ChangeButtonColor(false, disabledColor);
    }

    public void SetNormalColor()
    {
        ChangeButtonColor(true, normalColor);
    }

    private void ChangeButtonColor(bool isInteractable, Color targetColor)
    {
        ColorBlock cb = targetBtn.colors;

        cb.disabledColor = targetColor;

        targetBtn.colors = cb;

        targetBtn.interactable = isInteractable;
    }
}
