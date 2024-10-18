using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController instance;
    public static PlayerController Instance { get { return instance; } }

    Rigidbody2D rb;

    [SerializeField] float jumpForce;
    [SerializeField] private float jumpTimeMax;
    private float jumpTimeCounter;
    public float speed;
    public float maxSpeed = 100;
    public float maxAcceleration = 10;
    public float acceleration;
    public float distance = 0;

    public bool isHoldingJump = false;
    public bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleJump();

        distance += speed * Time.deltaTime;

        if (isGrounded)
        {
            // Tính tỷ lệ vận tốc hiện tại so với vận tốc tối đa
            float velocityRatio = speed / maxSpeed;

            // Tính gia tốc dựa trên tỷ lệ vận tốc hiện tại
            acceleration = maxAcceleration * (1 - velocityRatio);

            // Cộng gia tốc vào vận tốc hiện tại
            speed += acceleration * Time.deltaTime;

            // Giới hạn vận tốc không vượt quá maxSpeed
            if (speed >= maxSpeed)
            {
                speed = maxSpeed;
            }
        }
    }

    public void HandleJump()
    {

        if (Input.GetButtonDown("Jump"))
        {
            isHoldingJump = true;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
            jumpTimeCounter = jumpTimeMax;
        }

        if(Input.GetButton("Jump") && isHoldingJump)
        {
            if(jumpTimeCounter > 0) 
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isHoldingJump = false;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            isHoldingJump = false;
        }
    }
}
