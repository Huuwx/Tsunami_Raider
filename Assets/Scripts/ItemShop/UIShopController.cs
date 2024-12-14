using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIShopController : MonoBehaviour
{
    private static UIShopController instance;

    public static UIShopController Instance { get { return instance; } }

    [SerializeField] TextMeshProUGUI coinNumberText;
    [SerializeField] TextMeshProUGUI respawnItemNumberText;
    [SerializeField] TextMeshProUGUI respawnItemPriceText;
    [SerializeField] TextMeshProUGUI rocketItemNumberText;
    [SerializeField] TextMeshProUGUI rocketItemPriceText;
    [SerializeField] GameObject notification;

    void Start()
    {
        instance = this;

        coinNumberText.text = GameManager.Instance.data.currentCoin.ToString();
        respawnItemNumberText.text = GameManager.Instance.data.currentRespawnItem.ToString();
        respawnItemPriceText.text = GameManager.Instance.data.respawnItemPrice.ToString();
        rocketItemNumberText.text = GameManager.Instance.data.currentRocketItem.ToString();
        rocketItemPriceText.text = GameManager.Instance.data.rocketItemPrice.ToString();
    }

    public void UpdateTextAfterBuyRI()
    {
        coinNumberText.text = GameManager.Instance.data.currentCoin.ToString();
        respawnItemNumberText.text = GameManager.Instance.data.currentRespawnItem.ToString();
    }

    public void UpdateTextAfterBuyROI()
    {
        coinNumberText.text = GameManager.Instance.data.currentCoin.ToString();
        rocketItemNumberText.text = GameManager.Instance.data.currentRocketItem.ToString();
    }

    public void Notification()
    {
        notification.SetActive(true);
    }
}
