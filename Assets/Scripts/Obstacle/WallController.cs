using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : ObstacleController
{
    [SerializeField] ParticleSystem fallParticle;

    public float fallPos;
    public float fallStart;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        if (transform.position.x <= fallStart)
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = new Vector3(transform.position.x, fallPos, transform.position.z);

        float t = 0;

        while (t <= 1)
        {
            transform.position = Vector3.Lerp(startPos, endPos, t);

            t += Time.deltaTime * 0.7f;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            fallParticle.Play();
        }
    }
}
