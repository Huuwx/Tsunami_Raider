using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI coinCounterText;

    private void Awake()
    {
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
        int distance = Mathf.FloorToInt(gameManager.distance);
        distanceText.text = distance + "m";

        int coinCounter = gameManager.coinCounter;
        coinCounterText.text = coinCounter + "";
    }
}
