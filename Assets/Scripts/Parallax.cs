using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float depth = 1;

    PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float realVelocity = playerController.GetXVelocity() / depth;
        Vector2 pos = transform.localPosition;

        Debug.Log("Current X position: " + pos.x);
        Debug.Log("Real Velocity: " + realVelocity);

        pos.x -= realVelocity * Time.deltaTime;

        if(pos.x <= -15)
        {
            Debug.Log("dm");
            pos.x = 40;
        }

        transform.localPosition = pos;
    }
}
