using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UICSShopController : MonoBehaviour
{
    private static UICSShopController instance;

    public static UICSShopController Instance { get { return instance; } }
    [Header("---------- List Chars Text ----------")]
    [SerializeField] private List<TextMeshProUGUI> listCharsText;

    [Header("---------- List Chars Btn ----------")]
    [SerializeField] private List<Button> listCharsBtn;

    [Header("---------- List Ships Text ----------")]
    [SerializeField] private List<TextMeshProUGUI> listShipsText;

    [Header("---------- List Ships Btn ----------")]
    [SerializeField] private List<Button> listShipsBtn;

    [SerializeField] TextMeshProUGUI coinNumberText;
    [SerializeField] TextMeshProUGUI char_ItemText;
    [SerializeField] TextMeshProUGUI char_ItemTextBack;
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
    [SerializeField] TextMeshProUGUI ship_ItemText;
    [SerializeField] TextMeshProUGUI ship_ItemTextBack;
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
        if (GameManager.Instance.data.getCharSprite() == null || GameManager.Instance.data.getCharSprite() == Resources.Load<Sprite>($"Characters/{GameObject.Find("Icon_Char").GetComponent<Image>().sprite.name}"))
        {
            UsedCharBtn();
        }
        else
        {
            UseCharBtn();
        }
        if (GameManager.Instance.data.getShipSprite() == null || GameManager.Instance.data.getShipSprite() == Resources.Load<Sprite>($"Ships/{GameObject.Find("Icon_Ship").GetComponent<Image>().sprite.name}"))
        {
            UsedShipBtn();
        }
        else
        {
            UseShipBtn();
        }
        if (GameManager.Instance.data.getHaveChar1())
        {
            Sprite character = GameObject.Find("Icon_Char1").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getCharSprite() == Resources.Load<Sprite>($"Characters/{character.name}"))
            {
                UsedChar1Btn();
            }
            else
            {
                UseChar1Btn();
            }
        }
        if (GameManager.Instance.data.getHaveChar2())
        {
            Sprite character = GameObject.Find("Icon_Char2").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getCharSprite() == Resources.Load<Sprite>($"Characters/{character.name}"))
            {
                UsedChar2Btn();
            }
            else
            {
                UseChar2Btn();
            }
        }
        if (GameManager.Instance.data.getHaveChar3())
        {
            Sprite character = GameObject.Find("Icon_Char3").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getCharSprite() == Resources.Load<Sprite>($"Characters/{character.name}"))
            {
                UsedChar3Btn();
            }
            else
            {
                UseChar3Btn();
            }
        }
        if (GameManager.Instance.data.getHaveChar4())
        {
            Sprite character = GameObject.Find("Icon_Char4").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getCharSprite() == Resources.Load<Sprite>($"Characters/{character.name}"))
            {
                UsedChar4Btn();
            }
            else
            {
                UseChar4Btn();
            }
        }
        if (GameManager.Instance.data.getHaveShip1())
        {
            Sprite ship = GameObject.Find("Icon_Ship1").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getShipSprite() == Resources.Load<Sprite>($"Ships/{ship.name}"))
            {
                UsedShip1Btn();
            }
            else
            {
                UseShip1Btn();
            }
        }
        if (GameManager.Instance.data.getHaveShip2())
        {
            Sprite ship = GameObject.Find("Icon_Ship2").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getShipSprite() == Resources.Load<Sprite>($"Ships/{ship.name}"))
            {
                UsedShip2Btn();
            }
            else
            {
                UseShip2Btn();
            }
        }
        if (GameManager.Instance.data.getHaveShip3())
        {
            Sprite ship = GameObject.Find("Icon_Ship3").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getShipSprite() == Resources.Load<Sprite>($"Ships/{ship.name}"))
            {
                UsedShip3Btn();
            }
            else
            {
                UseShip3Btn();
            }
        }
        if (GameManager.Instance.data.getHaveShip4())
        {
            Sprite ship = GameObject.Find("Icon_Ship4").GetComponent<Image>().sprite;
            if (GameManager.Instance.data.getShipSprite() == Resources.Load<Sprite>($"Ships/{ship.name}"))
            {
                UsedShip4Btn();
            }
            else
            {
                UseShip4Btn();
            }
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

    public void UsedCharBtn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        char_ItemText.text = "USED";
        char_ItemTextBack.text = "USED";
    }

    public void UseCharBtn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        char_ItemText.text = "USE";
        char_ItemTextBack.text = "USE";
    }

    public void UsedShipBtn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        ship_ItemText.text = "USED";
        ship_ItemTextBack.text = "USED";
    }

    public void UseShipBtn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        ship_ItemText.text = "USE";
        ship_ItemTextBack.text = "USE";
    }

    public void UsedChar1Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC1").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        char_1_ItemText.text = "USED";
        char_1_ItemTextBack.text = "USED";
    }

    public void UseChar1Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC1").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        char_1_ItemText.text = "USE";
        char_1_ItemTextBack.text = "USE";
    }

    public void UsedChar2Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC2").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        char_2_ItemText.text = "USED";
        char_2_ItemTextBack.text = "USED";
    }

    public void UseChar2Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC2").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        char_2_ItemText.text = "USE";
        char_2_ItemTextBack.text = "USE";
    }

    public void UsedChar3Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC3").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        char_3_ItemText.text = "USED";
        char_3_ItemTextBack.text = "USED";
    }

    public void UseChar3Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC3").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        char_3_ItemText.text = "USE";
        char_3_ItemTextBack.text = "USE";
    }

    public void UsedChar4Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC4").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        char_4_ItemText.text = "USED";
        char_4_ItemTextBack.text = "USED";
    }

    public void UseChar4Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddC4").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        char_4_ItemText.text = "USE";
        char_4_ItemTextBack.text = "USE";
    }

    public void UsedShip1Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS1").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        ship_1_ItemText.text = "USED";
        ship_1_ItemTextBack.text = "USED";
    }

    public void UseShip1Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS1").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        ship_1_ItemText.text = "USE";
        ship_1_ItemTextBack.text = "USE";
    }

    public void UsedShip2Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS2").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        ship_2_ItemText.text = "USED";
        ship_2_ItemTextBack.text = "USED";
    }

    public void UseShip2Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS2").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        ship_2_ItemText.text = "USE";
        ship_2_ItemTextBack.text = "USE";
    }

    public void UsedShip3Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS3").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        ship_3_ItemText.text = "USED";
        ship_3_ItemTextBack.text = "USED";
    }

    public void UseShip3Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS3").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        ship_3_ItemText.text = "USE";
        ship_3_ItemTextBack.text = "USE";
    }

    public void UsedShip4Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS4").GetComponent<UseBtnStatus>();
        useBtnStatus.SetDisableColor();
        ship_4_ItemText.text = "USED";
        ship_4_ItemTextBack.text = "USED";
    }

    public void UseShip4Btn()
    {
        UseBtnStatus useBtnStatus = GameObject.Find("Button_AddS4").GetComponent<UseBtnStatus>();
        useBtnStatus.SetNormalColor();
        ship_4_ItemText.text = "USE";
        ship_4_ItemTextBack.text = "USE";
    }

    public void SetUseAllCharTxt()
    {
        foreach(var item in listCharsText)
        {
            if(item.text == "USED")
            {
                item.text = "USE";
            }
        }
    }

    public void SetUseAllShipTxt()
    {
        foreach (var item in listShipsText)
        {
            if (item.text == "USED")
            {
                item.text = "USE";
            }
        }
    }

    public void SetUseAllCharBtn()
    {
        foreach(var item in listCharsBtn)
        {
            UseBtnStatus useBtnStatus = item.GetComponent<UseBtnStatus>();
            useBtnStatus.SetNormalColor();
        }
    }

    public void SetUseAllShipBtn()
    {
        foreach (var item in listShipsBtn)
        {
            UseBtnStatus useBtnStatus = item.GetComponent<UseBtnStatus>();
            useBtnStatus.SetNormalColor();
        }
    }
}
