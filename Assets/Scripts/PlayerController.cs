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

    public bool isHoldingJump = false;
    private bool isGrounded = true;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            isGrounded = true;
            Debug.Log("Cham dat");
        }
    }
}
