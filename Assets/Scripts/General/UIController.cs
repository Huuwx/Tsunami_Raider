using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    PlayerController playerController;
    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI coinCounterText;

    private void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        distanceText = GameObject.Find("Distance Text").GetComponent<TextMeshProUGUI>();
        coinCounterText = GameObject.Find("Coin Counter Text").GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(playerController.distance);
        distanceText.text = distance + "m";

        int coinCounter = playerController.coinCounter;
        coinCounterText.text = coinCounter + "";
    }
}
