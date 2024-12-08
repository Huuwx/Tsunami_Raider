using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopButtonController : MonoBehaviour
{
    public void BuyRespawnItem()
    {
        if (ItemShopController.Instance.data.currentCoin >= ItemShopController.Instance.data.respawnItemPrice)
        {
            ItemShopController.Instance.data.currentCoin -= ItemShopController.Instance.data.respawnItemPrice;
            ItemShopController.Instance.data.currentRespawnItem += 1;
            ItemShopController.Instance.SaveData();
            UIShopController.Instance.UpdateTextAfterBuyRI();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyRocketItem()
    {
        if (ItemShopController.Instance.data.currentCoin >= ItemShopController.Instance.data.rocketItemPrice)
        {
            ItemShopController.Instance.data.currentCoin -= ItemShopController.Instance.data.rocketItemPrice;
            ItemShopController.Instance.data.currentRocketItem += 1;
            ItemShopController.Instance.SaveData();
            UIShopController.Instance.UpdateTextAfterBuyROI();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }
}
