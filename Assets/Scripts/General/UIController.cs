using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    PlayerController playerController;
    public TextMeshProUGUI distanceText;

    private void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        distanceText = GameObject.Find("Distance Text").GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(playerController.distance);
        distanceText.text = distance + " m";
    }
}
