using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    private static UIController instance;

    public static UIController Instance { get { return instance; } }

    [SerializeField] GameManager gameManager;

    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI coinCounterText;
    [SerializeField] TextMeshProUGUI distanceTextGO;
    [SerializeField] TextMeshProUGUI coinCounterTextGO;
    [SerializeField] TextMeshProUGUI highestDistanceTextGO;

    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
        distanceText = GameObject.Find("Distance Text").GetComponent<TextMeshProUGUI>();
        coinCounterText = GameObject.Find("Coin Counter Text").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(gameManager.distance);
        distanceText.text = distance + "m";

        int coinCounter = gameManager.coinCounter;
        coinCounterText.text = coinCounter + "";
    }

    public void SetActivePausePanel(bool active)
    {
        pausePanel.SetActive(active);
    }

    public void GameOver()
    {
        distanceTextGO.text = distanceText.text;
        coinCounterTextGO.text = coinCounterText.text;
        highestDistanceTextGO.text = Mathf.FloorToInt(gameManager.data.highestDistance) + "m";
        gameOverPanel.SetActive(true);
        Animator GOanimator = GameObject.Find("GameOver Popup").GetComponent<Animator>();
        GOanimator.SetBool("PopUp", true);
    }
}
