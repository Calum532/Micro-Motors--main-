using System.Collections;
using UnityEngine;

public class BoostPadScript : MonoBehaviour
{
    [Header("Particles")]
    public GameObject speedboostParticle;

    [Header("Settings")]
    public float boostAmount = 450000f;
    public float boostDuration = 2.5f;

    private GameObject instantiateCache;
    private Rigidbody _rb;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("AICar")) // if player or ai are deteced
        {
            // get rigidbody
            _rb = other.GetComponent<Rigidbody>();

            // particle stuff

            // pickup particle
            instantiateCache = Instantiate(speedboostParticle, other.transform.position, Quaternion.identity); 
            Destroy(instantiateCache, 1f);

            // afterburner effect
            // _rb.GetComponentInChildren<ParticleSystem>().Play();

            // speed boost
            if (other.CompareTag("Player"))
            {
                FindObjectOfType<AudioManager>().Play("Boost");
            }

            // we goin fast
            StartCoroutine(SpeedBoost());
        }
    }

    public IEnumerator SpeedBoost()
    {
        _rb.AddForce(_rb.transform.forward * boostAmount);

        yield return new WaitForSeconds(boostDuration);
    }
}
