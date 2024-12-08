using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController instance;
    public static PlayerController Instance { get { return instance; } }

    [SerializeField] private GameManager gameManager;
    [SerializeField] private ParticleController particleController;
    [SerializeField] private NitroController nitroController;
    [SerializeField] private PlatformSpawner pSpawner;
    [SerializeField] private EnemySpawner eSpawner;

    [SerializeField] private GameObject rocket_1;

    private Vector3 startPos;

    public Rigidbody2D rb;

    private Animator animator;

    [SerializeField] float jumpForce;
    public float currentSpeed;
    public float speed;
    public float maxSpeed = 100;
    public float maxAcceleration = 10;
    public float acceleration;
    public float currentAcceleration;
    public float BoostedPos;

    public bool isHoldingJump = false;
    public bool isGrounded = true;
    public bool isBoosted = false;
    public bool isJumpBoosted = true;
    private bool canJump = true;
    private bool isDead = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            if (canJump)
            {
                HandleJump();
            }

            if (isGrounded)
            {
                nitroController.RefillJumpTime();
            }

            gameManager.GainedDistance(speed);

            if (isGrounded && !isBoosted && !isDead)
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
                speed = maxSpeed * 3;
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
            if (gameManager.distance >= 1500f)
            {
                isBoosted = false;
            }
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

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
        }

        if (isHoldingJump)
        {
            if (nitroController.getJumpTimeCounter() > 0)
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

    private IEnumerator PushBack()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = new Vector3(startPos.x - 10f, startPos.y + 5f, transform.position.z);

        float t = 0;

        while (t <= 1)
        {
            transform.position = Vector3.Lerp(startPos, endPos, t);

            t += Time.deltaTime * 2f;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPos;
    }

    public void DieA()
    {
        isDead = true;
        animator.SetBool("Die", isDead);
        StartCoroutine(PushBack());
    }

    public void Die()
    {
        rb.simulated = false;
        rb.velocity = new Vector2(0, 0);
        transform.localScale = new Vector3(0, 0, 0);
        speed = 0;
        pSpawner.canSpawn = false;
        eSpawner.canSpawn = false;
        //gameManager.GameOver();
    }

    public void Respawn()
    {
        rb.simulated = true;
        isDead = false;
        animator.SetBool("Die", isDead);
        transform.position = startPos;
        transform.localScale = new Vector3(1, 1, 1);
        speed = currentSpeed;
        pSpawner.canSpawn = true;
        eSpawner.canSpawn = true;
    }

    public IEnumerator Undying()
    {
        int playerLayer = LayerMask.NameToLayer("Player");
        int obstacleLayer = LayerMask.NameToLayer("Obstacle");

        Physics2D.IgnoreLayerCollision(playerLayer, obstacleLayer, true);

        animator.SetBool("Undying", true);
        yield return new WaitForSeconds(3f);
        Debug.Log("?");
        animator.SetBool("Undying", false);

        Physics2D.IgnoreLayerCollision(playerLayer, obstacleLayer, false);
    }
}
