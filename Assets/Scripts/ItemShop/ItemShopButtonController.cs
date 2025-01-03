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

    public void BuyChar1()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar1Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar1Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyChar2()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar2Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar2Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyChar3()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar3Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar3Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyChar4()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar4Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar4Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyShip1()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip1Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip1Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyShip2()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip2Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip2Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyShip3()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip3Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip3Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }

    public void BuyShip4()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip4Price())
        {
            int currentCoin = GameManager.Instance.data.getCurrentCoin();

            GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip4Price());
            GameManager.Instance.SaveData();
        }
        else
        {
            UIShopController.Instance.Notification();
        }
    }
}
