using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICSShopController : MonoBehaviour
{
    private static UICSShopController instance;

    public static UICSShopController Instance { get { return instance; } }

    [SerializeField] TextMeshProUGUI coinNumberText;
    [SerializeField] TextMeshProUGUI char_1_ItemPriceText;
    [SerializeField] TextMeshProUGUI char_2_ItemPriceText;
    [SerializeField] TextMeshProUGUI char_3_ItemPriceText;
    [SerializeField] TextMeshProUGUI char_4_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_1_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_2_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_3_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_4_ItemPriceText;
    [SerializeField] GameObject notification;

    void Start()
    {
        instance = this;

        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();
        char_1_ItemPriceText.text = GameManager.Instance.data.getChar1Price().ToString();
        char_2_ItemPriceText.text = GameManager.Instance.data.getChar2Price().ToString();
        char_3_ItemPriceText.text = GameManager.Instance.data.getChar3Price().ToString();
        char_4_ItemPriceText.text = GameManager.Instance.data.getChar4Price().ToString();
        ship_1_ItemPriceText.text = GameManager.Instance.data.getShip1Price().ToString();
        ship_2_ItemPriceText.text = GameManager.Instance.data.getShip2Price().ToString();
        ship_3_ItemPriceText.text = GameManager.Instance.data.getShip3Price().ToString();
        ship_4_ItemPriceText.text = GameManager.Instance.data.getShip4Price().ToString();
    }

    public void UpdateTextAfterBuyRI()
    {
        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();
    }

    public void UpdateTextAfterBuyROI()
    {
        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();
    }

    public void Notification()
    {
        notification.SetActive(true);
    }
}
