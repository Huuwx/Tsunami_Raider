using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.VisualScripting;

public class UICSShopController : MonoBehaviour
{
    private static UICSShopController instance;
    public static UICSShopController Instance { get { return instance; } }

    [System.Serializable]
    public class ShopItem
    {
        public Button button;
        public TextMeshProUGUI itemText;
        public TextMeshProUGUI itemTextBack;
        public TextMeshProUGUI priceText;
        public string iconName;
    }

    [Header("Shop Items")]
    [SerializeField] private List<ShopItem> characterItems = new List<ShopItem>();
    [SerializeField] private List<ShopItem> shipItems = new List<ShopItem>();
    [SerializeField] private TextMeshProUGUI coinNumberText;
    [SerializeField] private GameObject notification;

    void Start()
    {
        instance = this;
        InitializeShop();
    }

    private void InitializeShop()
    {
        // Set coin text
        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();

        // Initialize characters
        SetStatusAllCharacters();

        // Initialize ships
        SetStatusAllShips();
    }

    private void UpdateItemStatus(ShopItem item, string iconName, string resourceFolder, Sprite currentSprite)
    {
        Sprite itemSprite = GameObject.Find(iconName).GetComponent<Image>().sprite;
        bool isUsed = currentSprite == Resources.Load<Sprite>($"{resourceFolder}/{itemSprite.name}");

        UseBtnStatus btnStatus = item.button.GetComponent<UseBtnStatus>();
        if (isUsed)
        {
            btnStatus.SetDisableColor();
            SetItemText(item, "USED");
        }
        else
        {
            btnStatus.SetNormalColor();
            SetItemText(item, "USE");
        }
    }

    private void SetItemText(ShopItem item, string text)
    {
        item.itemText.text = text;
        item.itemTextBack.text = text;
    }

    private int GetCharacterPrice(int index)
    {
        switch (index)
        {
            case 1: return GameManager.Instance.data.getChar1Price();
            case 2: return GameManager.Instance.data.getChar2Price();
            case 3: return GameManager.Instance.data.getChar3Price();
            case 4: return GameManager.Instance.data.getChar4Price();
            default: return 0;
        }
    }

    private bool GetHasCharacter(int index)
    {
        switch (index)
        {
            case 1: return GameManager.Instance.data.getHaveChar1();
            case 2: return GameManager.Instance.data.getHaveChar2();
            case 3: return GameManager.Instance.data.getHaveChar3();
            case 4: return GameManager.Instance.data.getHaveChar4();
            default: return false;
        }
    }

    private int GetShipPrice(int index)
    {
        switch (index)
        {
            case 1: return GameManager.Instance.data.getShip1Price();
            case 2: return GameManager.Instance.data.getShip2Price();
            case 3: return GameManager.Instance.data.getShip3Price();
            case 4: return GameManager.Instance.data.getShip4Price();
            default: return 0;
        }
    }

    private bool GetHasShip(int index)
    {
        switch (index)
        {
            case 1: return GameManager.Instance.data.getHaveShip1();
            case 2: return GameManager.Instance.data.getHaveShip2();
            case 3: return GameManager.Instance.data.getHaveShip3();
            case 4: return GameManager.Instance.data.getHaveShip4();
            default: return false;
        }
    }

    public void UpdateTextAfterBuy()
    {
        coinNumberText.text = GameManager.Instance.data.getCurrentCoin().ToString();
    }

    public void Notification()
    {
        notification.SetActive(true);
    }

    public void SetStatusAllCharacters()
    {
        if (GameManager.Instance.data.getCharSprite() != null)
        {
            for (int i = 0; i < characterItems.Count; i++)
            {
                var item = characterItems[i];
                if (i == 0) // Default character
                {
                    UpdateItemStatus(item, "Icon_Char", "Characters", GameManager.Instance.data.getCharSprite());
                }
                else
                {
                    bool hasChar = GetHasCharacter(i);
                    if (hasChar)
                    {
                        UpdateItemStatus(item, $"Icon_Char{i}", "Characters", GameManager.Instance.data.getCharSprite());
                    }
                    item.priceText.text = GetCharacterPrice(i).ToString();
                }
            }
        }
    }

    public void SetStatusAllShips()
    {
        if (GameManager.Instance.data.getShipSprite() != null){
            for (int i = 0; i < shipItems.Count; i++)
            {
                var item = shipItems[i];
                if (i == 0) // Default ship
                {
                    UpdateItemStatus(item, "Icon_Ship", "Ships", GameManager.Instance.data.getShipSprite());
                }
                else
                {
                    bool hasShip = GetHasShip(i);
                    if (hasShip)
                    {
                        UpdateItemStatus(item, $"Icon_Ship{i}", "Ships", GameManager.Instance.data.getShipSprite());
                    }
                    item.priceText.text = GetShipPrice(i).ToString();
                }
            }
        }
    }

    public void UpdateUsedItem(List<ShopItem> items, string resourceFolder, Sprite currentSprite)
    {
        foreach (var item in items)
        {
            Sprite itemSprite = GameObject.Find(item.iconName).GetComponent<Image>().sprite;
            bool isUsed = currentSprite == Resources.Load<Sprite>($"{resourceFolder}/{itemSprite.name}");
            if (isUsed)
            {
                item.button.GetComponent<UseBtnStatus>().SetDisableColor();
                SetItemText(item, "USED");
            }
        }
    }

    // Public methods for external calls
    public void SetUsedCharacter() => UpdateUsedItem(characterItems, "Characters", GameManager.Instance.data.getCharSprite());
    public void SetUsedShip() => UpdateUsedItem(shipItems, "Ships", GameManager.Instance.data.getShipSprite());
}