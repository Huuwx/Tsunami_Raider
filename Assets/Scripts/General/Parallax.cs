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
        float realVelocity = playerController.speed / depth;
        Vector2 pos = transform.localPosition;

        pos.x -= realVelocity * Time.deltaTime;

        if(pos.x <= -25)
        {
            pos.x = 40;
        }

        transform.localPosition = pos;
    }
}
