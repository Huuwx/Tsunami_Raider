using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController instance;
    public static PlayerController Instance { get { return instance; } }

    Rigidbody2D rb;

    [SerializeField] float jumpForce;
    [SerializeField] float jumpNitro;
    [SerializeField] private float jumpCount;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        jumpCount = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(jumpCount < 1)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpCount++;
            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpNitro);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            jumpCount = 0;
            Debug.Log("Cham dat");
        }
    }
}
