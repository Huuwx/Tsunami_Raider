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

        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();
        respawnItemNumberText.text = GameManager.Instance.data.getCurrentRespawnItem().ToString();
        respawnItemPriceText.text = GameManager.Instance.data.getRespawnItemPrice().ToString();
        rocketItemNumberText.text = GameManager.Instance.data.getCurrentRocketItem().ToString();
        rocketItemPriceText.text = GameManager.Instance.data.getRocketItemPrice().ToString();
    }

    public void UpdateTextAfterBuyRI()
    {
        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();
        respawnItemNumberText.text = GameManager.Instance.data.getCurrentRespawnItem().ToString();
    }

    public void UpdateTextAfterBuyROI()
    {
        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();
        rocketItemNumberText.text = GameManager.Instance.data.getCurrentRocketItem().ToString();
    }

    public void Notification()
    {
        notification.SetActive(true);
    }
}
