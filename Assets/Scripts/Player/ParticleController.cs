using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] ParticleSystem movementParticle;
    [SerializeField] ParticleSystem fallParticle;
    [SerializeField] ParticleSystem bNitroPartical;
    [SerializeField] ParticleSystem fNitroPartical;
    [SerializeField] ParticleSystem rocket1Particle;

    //[Range(0, 10)]
    //[SerializeField] int occurAfterVelocity;

    //[Range(0, 0.2f)]
    //[SerializeField] float dustFormationPeriod;

    //[SerializeField] Rigidbody2D playerRb;

    //float counter;
    //bool isOnGround;

    //private void Update()
    //{
    //    counter += Time.deltaTime;

    //    if(isOnGround && Mathf.Abs(playerRb.velocity.x) > occurAfterVelocity )
    //    {
    //        Debug.Log("ok");
    //        if(counter > dustFormationPeriod)
    //        {
    //            movementParticle.Play();
    //            counter = 0;
    //        }
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Ground"))
    //    {
    //        fallParticle.Play();
    //        movementParticle.Play();
    //        //isOnGround = true;
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Ground"))
    //    {
    //        movementParticle.Stop();
    //        //isOnGround = false;
    //    }
    //}

    public void PlayBNitro()
    {
        bNitroPartical.Play();
    }

    public void StopBNitro() 
    {
        bNitroPartical.Stop();
    }

    public void PlayFNitro()
    {
        fNitroPartical.Play();
    }

    public void StopFNitro()
    {
        fNitroPartical.Stop();
    }

    public void PlayRocket1Nitro()
    {
        rocket1Particle.Play();
    }

    public void PlayMovParticle()
    {
        movementParticle.Play();
    }

    public void StopMovParticle()
    {
        movementParticle.Stop();
    }

    public void PlayFallParticle()
    {
        fallParticle.Play();
    }

    public void StopRocket1Nitro()
    {
        rocket1Particle.Stop();
    }
}
