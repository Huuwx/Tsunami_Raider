using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopButtonController : MonoBehaviour
{
    public void BuyRespawnItem()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getRespawnItemPrice())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();
            int currentRespawnItem = GameManager.Instance.data.getCurrentRespawnItem();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getRespawnItemPrice());
            GameManager.Instance.data.setCurrentRespawnItem(currentRespawnItem += 1);
            UIShopController.Instance.UpdateTextAfterBuyRI();
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyRocketItem()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getRocketItemPrice())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();
            int currentRocketItem = GameManager.Instance.data.getCurrentRocketItem();


            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getRocketItemPrice());
            GameManager.Instance.data.setCurrentRocketItem(currentRocketItem += 1);
            UIShopController.Instance.UpdateTextAfterBuyROI();
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }
}
