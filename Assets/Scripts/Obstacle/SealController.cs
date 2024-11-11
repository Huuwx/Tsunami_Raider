using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealController : ObstacleController
{
    public float posToJump = -4f;
    public float fallPos;
    public float jumpPoint = 0f;
    public float fallStart;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        if (transform.position.x <= jumpPoint && transform.position.x >= fallStart)
        {
            StartCoroutine(WaterJump());
        }
        else
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator WaterJump()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = new Vector3(transform.position.x, posToJump, transform.position.z);

        Debug.Log("ok");

        float t = 0;

        while (t <= 1)
        {
            transform.position = Vector3.Lerp(startPos, endPos, t);

            t += Time.deltaTime * 2.5f;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPos;

    }

    private IEnumerator Fall()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = new Vector3(transform.position.x, fallPos, transform.position.z);

        float t = 0;

        while (t <= 1)
        {
            transform.position = Vector3.Lerp(startPos, endPos, t);

            t += Time.deltaTime * 0.5f;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPos;
    }
}
