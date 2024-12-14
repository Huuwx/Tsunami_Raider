using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopButtonController : MonoBehaviour
{
    public void BuyRespawnItem()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.currentCoin >= GameManager.Instance.data.respawnItemPrice)
        {
            GameManager.Instance.data.currentCoin -= GameManager.Instance.data.respawnItemPrice;
            GameManager.Instance.data.currentRespawnItem += 1;
            GameManager.Instance.SaveData();
            UIShopController.Instance.UpdateTextAfterBuyRI();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyRocketItem()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.currentCoin >= GameManager.Instance.data.rocketItemPrice)
        {
            GameManager.Instance.data.currentCoin -= GameManager.Instance.data.rocketItemPrice;
            GameManager.Instance.data.currentRocketItem += 1;
            GameManager.Instance.SaveData();
            UIShopController.Instance.UpdateTextAfterBuyROI();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }
}
