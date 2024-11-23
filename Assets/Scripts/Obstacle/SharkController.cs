using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : ObstacleController
{
    [SerializeField] ParticleSystem fallParticle;

    public float posToJump = -4f;
    public float jumpPoint = 0f;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        if (transform.position.x <= jumpPoint)
        {
            StartCoroutine(WaterJump());
        }
        if(transform.position.x < jumpPoint - 1f)
        {
            fallParticle.Stop();
        }
    }

    private IEnumerator WaterJump()
    {
        fallParticle.Play();
        Vector3 startPos = transform.position;
        Vector3 endPos = new Vector3(transform.position.x, posToJump, transform.position.z);

        float t = 0;

        while (t <= 1)
        {
            transform.position = Vector3.Lerp(startPos, endPos, t);

            t += Time.deltaTime * 4f;

            yield return new WaitForEndOfFrame();
        }

        transform.position = endPos;
    }
}
