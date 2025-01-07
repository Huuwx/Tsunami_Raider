using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

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

    public void UseChar()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        Sprite character = GameObject.Find("Icon_Char").GetComponent<Image>().sprite;
        GameManager.Instance.data.setCharSprite(character.name);
        GameManager.Instance.SaveData();
        UICSShopController.Instance.SetUseAllCharacters();
        UICSShopController.Instance.SetUsedCharacter();
    }

    public void BuyChar1()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveChar1())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar1Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar1Price());
                GameManager.Instance.data.setHaveChar1(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllCharacters();
                UICSShopController.Instance.SetUsedCharacter();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite character = GameObject.Find("Icon_Char1").GetComponent<Image>().sprite;
            GameManager.Instance.data.setCharSprite(character.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllCharacters();
            UICSShopController.Instance.SetUsedCharacter();
        }
    }

    public void BuyChar2()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveChar2())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar2Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar2Price());
                GameManager.Instance.data.setHaveChar2(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllCharacters();
                UICSShopController.Instance.SetUsedCharacter();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite character = GameObject.Find("Icon_Char2").GetComponent<Image>().sprite;
            GameManager.Instance.data.setCharSprite(character.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllCharacters();
            UICSShopController.Instance.SetUsedCharacter();
        }
    }

    public void BuyChar3()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveChar3())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar3Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar3Price());
                GameManager.Instance.data.setHaveChar3(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllCharacters();
                UICSShopController.Instance.SetUsedCharacter();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite character = GameObject.Find("Icon_Char3").GetComponent<Image>().sprite;
            GameManager.Instance.data.setCharSprite(character.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllCharacters();
            UICSShopController.Instance.SetUsedCharacter();
        }
    }

    public void BuyChar4()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveChar4())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getChar4Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getChar4Price());
                GameManager.Instance.data.setHaveChar4(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllCharacters();
                UICSShopController.Instance.SetUsedCharacter();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite character = GameObject.Find("Icon_Char4").GetComponent<Image>().sprite;
            GameManager.Instance.data.setCharSprite(character.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllCharacters();
            UICSShopController.Instance.SetUsedCharacter();
        }
    }

    public void UseShip()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        Sprite ship = GameObject.Find("Icon_Ship").GetComponent<Image>().sprite;
        GameManager.Instance.data.setShipSprite(ship.name);
        GameManager.Instance.SaveData();
        UICSShopController.Instance.SetUseAllShips();
        UICSShopController.Instance.SetUsedShip();
    }

    public void BuyShip1()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveShip1())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip1Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip1Price());
                GameManager.Instance.data.setHaveShip1(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllShips();
                UICSShopController.Instance.SetUsedShip();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite ship = GameObject.Find("Icon_Ship1").GetComponent<Image>().sprite;
            GameManager.Instance.data.setShipSprite(ship.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllShips();
            UICSShopController.Instance.SetUsedShip();
        }
    }

    public void BuyShip2()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveShip2())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip2Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip2Price());
                GameManager.Instance.data.setHaveShip2(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllShips();
                UICSShopController.Instance.SetUsedShip();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite ship = GameObject.Find("Icon_Ship2").GetComponent<Image>().sprite;
            GameManager.Instance.data.setShipSprite(ship.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllShips();
            UICSShopController.Instance.SetUsedShip();
        }
    }

    public void BuyShip3()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveShip3())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip3Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip3Price());
                GameManager.Instance.data.setHaveShip3(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllShips();
                UICSShopController.Instance.SetUsedShip();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite ship = GameObject.Find("Icon_Ship3").GetComponent<Image>().sprite;
            GameManager.Instance.data.setShipSprite(ship.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllShips();
            UICSShopController.Instance.SetUsedShip();
        }
    }

    public void BuyShip4()
    {
        SoundController.Instance.PlayOneShot(SoundController.Instance.clickSound);
        if (!GameManager.Instance.data.getHaveShip4())
        {
            if (GameManager.Instance.data.getCurrentCoin() >= GameManager.Instance.data.getShip4Price())
            {
                int currentCoin = GameManager.Instance.data.getCurrentCoin();

                GameManager.Instance.data.setCurrentCoin(currentCoin -= GameManager.Instance.data.getShip4Price());
                GameManager.Instance.data.setHaveShip4(true);
                GameManager.Instance.SaveData();
                UICSShopController.Instance.SetUseAllShips();
                UICSShopController.Instance.SetUsedShip();
            }
            else
            {
                UICSShopController.Instance.Notification();
            }
        }
        else
        {
            Sprite ship = GameObject.Find("Icon_Ship4").GetComponent<Image>().sprite;
            GameManager.Instance.data.setShipSprite(ship.name);
            GameManager.Instance.SaveData();
            UICSShopController.Instance.SetUseAllShips();
            UICSShopController.Instance.SetUsedShip();
        }
    }
}
