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

    void Start()
    {
        instance = this;

        coinNumberText.text = ItemShopController.Instance.data.currentCoin.ToString();
        respawnItemNumberText.text = ItemShopController.Instance.data.currentRespawnItem.ToString();
        respawnItemPriceText.text = ItemShopController.Instance.data.respawnItemPrice.ToString();
        rocketItemNumberText.text = ItemShopController.Instance.data.currentRocketItem.ToString();
        rocketItemPriceText.text = ItemShopController.Instance.data.rocketItemPrice.ToString();
    }

    public void UpdateTextAfterBuyRI()
    {
        coinNumberText.text = ItemShopController.Instance.data.currentCoin.ToString();
        respawnItemNumberText.text = ItemShopController.Instance.data.currentRespawnItem.ToString();
    }

    public void UpdateTextAfterBuyROI()
    {
        coinNumberText.text = ItemShopController.Instance.data.currentCoin.ToString();
        rocketItemNumberText.text = ItemShopController.Instance.data.currentRocketItem.ToString();
    }
}
