using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController instance;
    public static PlayerController Instance { get { return instance; } }

    [SerializeField] private ParticleController particleController;
    [SerializeField] private NitroController nitroController;
    [SerializeField] private PlatformSpawner pSpawner;
    [SerializeField] private EnemySpawner eSpawner;

    [SerializeField] private GameObject rocket_1;

    private Vector3 startPos;

    public Rigidbody2D rb;

    [SerializeField] float jumpForce;
    public float currentSpeed;
    public float speed;
    public float maxSpeed = 100;
    public float maxAcceleration = 10;
    public float acceleration;
    public float distance = 0;
    public float BoostedPos;

    public int coinCounter = 0;

    public bool isHoldingJump = false;
    public bool isGrounded = true;
    public bool isBoosted = false;
    public bool isJumpBoosted = true;
    private bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(canJump)
        {
            HandleJump();
        }
        
        if(isGrounded) 
        {
            nitroController.RefillJumpTime();
        }
        
        distance += speed * Time.deltaTime;

        if (isGrounded && !isBoosted)
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

        if (isBoosted)
        {
            canJump = false;
            rocket_1.SetActive(true);
            speed = maxSpeed * 2;
            particleController.PlayRocket1Nitro();
            StartCoroutine(Boosted());
        }
        else
        {
            if (isJumpBoosted == false) 
            {
                canJump = true;
                rocket_1.SetActive(false);
                particleController.StopRocket1Nitro();
                speed = currentSpeed + 15f;
                StartCoroutine(BackFromBoosted());
                isJumpBoosted = true;
                pSpawner.canSpawn = true;
                eSpawner.canSpawn = true;
            }
            currentSpeed = speed;
        }
        if(distance >= 1500f)
        {
            isBoosted = false;
        }
    }

    public IEnumerator Boosted()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = new Vector3(BoostedPos, transform.position.y, transform.position.z);

        if (isJumpBoosted)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isJumpBoosted = false;
        }

        float t = 0;

        while (t <= 1)
        {
            transform.position = Vector3.Lerp(startPos, endPos, t);

            t += Time.deltaTime * 4f;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPos;
    }

    public IEnumerator BackFromBoosted()
    {
        Vector3 startPoss = transform.position;
        Vector3 endPos = new Vector3(startPos.x, transform.position.y, transform.position.z);

        float t = 0;

        while (t <= 1)
        {
            transform.position = Vector3.Lerp(startPoss, endPos, t);

            t += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPos;
    }

    public void HandleJump()
    {

        if (Input.GetButtonDown("Jump"))
        {
            particleController.PlayBNitro();
            particleController.PlayFNitro();
            isHoldingJump = true;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
        }

        if(isHoldingJump)
        {
            if(nitroController.getJumpTimeCounter() > 0) 
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                nitroController.SubtractJumpTime();
            }
            else
            {
                particleController.StopBNitro();
                particleController.StopFNitro();
                isHoldingJump = false;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            particleController.StopBNitro();
            particleController.StopFNitro();
            isHoldingJump = false;
        }
    }
}
