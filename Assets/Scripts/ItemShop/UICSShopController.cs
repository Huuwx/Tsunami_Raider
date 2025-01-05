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
    [SerializeField] TextMeshProUGUI char_1_ItemText;
    [SerializeField] TextMeshProUGUI char_1_ItemTextBack;
    [SerializeField] TextMeshProUGUI char_2_ItemPriceText;
    [SerializeField] TextMeshProUGUI char_2_ItemText;
    [SerializeField] TextMeshProUGUI char_2_ItemTextBack;
    [SerializeField] TextMeshProUGUI char_3_ItemPriceText;
    [SerializeField] TextMeshProUGUI char_3_ItemText;
    [SerializeField] TextMeshProUGUI char_3_ItemTextBack;
    [SerializeField] TextMeshProUGUI char_4_ItemPriceText;
    [SerializeField] TextMeshProUGUI char_4_ItemText;
    [SerializeField] TextMeshProUGUI char_4_ItemTextBack;
    [SerializeField] TextMeshProUGUI ship_1_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_1_ItemText;
    [SerializeField] TextMeshProUGUI ship_1_ItemTextBack;
    [SerializeField] TextMeshProUGUI ship_2_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_2_ItemText;
    [SerializeField] TextMeshProUGUI ship_2_ItemTextBack;
    [SerializeField] TextMeshProUGUI ship_3_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_3_ItemText;
    [SerializeField] TextMeshProUGUI ship_3_ItemTextBack;
    [SerializeField] TextMeshProUGUI ship_4_ItemPriceText;
    [SerializeField] TextMeshProUGUI ship_4_ItemText;
    [SerializeField] TextMeshProUGUI ship_4_ItemTextBack;
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
        if (GameManager.Instance.data.getHaveChar1())
        {
            char_1_ItemText.text = "USE";
            char_1_ItemTextBack.text = "USE";
        }
        if (GameManager.Instance.data.getHaveChar2())
        {
            char_2_ItemText.text = "USE";
            char_2_ItemTextBack.text = "USE";
        }
        if (GameManager.Instance.data.getHaveChar3())
        {
            char_3_ItemText.text = "USE";
            char_3_ItemTextBack.text = "USE";
        }
        if (GameManager.Instance.data.getHaveChar4())
        {
            char_4_ItemText.text = "USE";
            char_4_ItemTextBack.text = "USE";
        }
        if (GameManager.Instance.data.getHaveShip1())
        {
            ship_1_ItemText.text = "USE";
            ship_1_ItemTextBack.text = "USE";
        }
        if (GameManager.Instance.data.getHaveShip2())
        {
            ship_2_ItemText.text = "USE";
            ship_2_ItemTextBack.text = "USE";
        }
        if (GameManager.Instance.data.getHaveShip3())
        {
            ship_3_ItemText.text = "USE";
            ship_3_ItemTextBack.text = "USE";
        }
        if (GameManager.Instance.data.getHaveShip4())
        {
            ship_4_ItemText.text = "USE";
            ship_4_ItemTextBack.text = "USE";
        }
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
