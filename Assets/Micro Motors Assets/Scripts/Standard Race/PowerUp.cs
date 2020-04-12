using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject powerUp;
    public GameObject child1;
    public GameObject child2;
    public GameObject child3;
    public GameObject child4;
    //public GameObject FrontCam;
    //public GameObject ZoomedOutCam;

    [Header("3D audio")]
    public GameObject Swoosh;
    public GameObject SuperBoost;
    public GameObject Dunk;

    [Header("Particles/Effects")]
    public GameObject placeholder;

    [Header("Settings")]
    public float respawnDuration = 5f;
    public float effectDuration = 10f;
    public float grow;
    public float rotateSpeed;

    private int randomNum;

    private GameObject _cache;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("AICar"))
        {
            if (other.CompareTag("Player"))
            {
                FindObjectOfType<AudioManager>().Play("PickUp");
            }

            _cache = Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(_cache, 2f);

            StartCoroutine(respawnCountdown());

            randomNum = UnityEngine.Random.Range(0, 3);           

            if (randomNum == 0)
            {
                StartCoroutine(PickupShrink(other));
            }
            else if (randomNum == 1)
            {
                StartCoroutine(PickupSuperBoost(other));
            }
            else if (randomNum == 2)
            {
                StartCoroutine(PickupSlamDunk(other));
            }
        }
    }

    IEnumerator respawnCountdown()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        child1.GetComponent<MeshRenderer>().enabled = false;
        child2.GetComponent<MeshRenderer>().enabled = false;
        child3.GetComponent<MeshRenderer>().enabled = false;
        child4.GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(respawnDuration);

        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<Collider>().enabled = true;
        child1.GetComponent<MeshRenderer>().enabled = true;
        child2.GetComponent<MeshRenderer>().enabled = true;
        child3.GetComponent<MeshRenderer>().enabled = true;
        child4.GetComponent<MeshRenderer>().enabled = true;
    }

    IEnumerator PickupGrow(Collider racer)
    {
        if (racer.CompareTag("Player"))
        {
            Debug.Log($"<color=cyan>{racer.transform.name}: got 'Grow' pickup!</color>");
        }
        else
        {
            Debug.Log($"<color=yellow>{racer.transform.name}: got 'Grow' pickup!</color>");
        }      

        FindObjectOfType<AudioManager>().Play("Buff");
        //ZoomedOutCam.SetActive(true);
        //FrontCam.SetActive(false);
        racer.transform.localScale *= grow;

        yield return new WaitForSeconds(effectDuration);

        racer.transform.localScale /= grow;
        //FrontCam.SetActive(true);
        //ZoomedOutCam.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Debuff");
    }

    IEnumerator PickupShrink(Collider racer)
    {
        if (racer.CompareTag("Player"))
        {
            Debug.Log($"<color=cyan>{racer.transform.name}: got 'Shrink' pickup!</color>");
        }
        else
        {
            Debug.Log($"<color=yellow>{racer.transform.name}: got 'Shrink' pickup!</color>");
        }

        FindObjectOfType<AudioManager>().Play("Debuff");
        racer.transform.localScale /= grow;

        yield return new WaitForSeconds(effectDuration);

        racer.transform.localScale *= grow;
        FindObjectOfType<AudioManager>().Play("Buff");
    }

    IEnumerator PickupSlamDunk(Collider racer)
    {
        // debugging
        if (racer.CompareTag("Player"))
        {
            Debug.Log($"<color=cyan>{racer.transform.name}: got 'Slam Dunk' pickup!</color>");
        }
        else
        {
            Debug.Log($"<color=yellow>{racer.transform.name}: got 'Slam Dunk' pickup!</color>");
        }

        //audio
        _cache = Instantiate(Swoosh, racer.transform.position, Quaternion.identity);
        _cache.transform.parent = racer.transform;
        Destroy(_cache, 2f);

        //particles/effects

        //implementation
        racer.GetComponent<Rigidbody>().AddExplosionForce(1000f, racer.transform.position, 10f, 5f, ForceMode.Acceleration);

        yield return new WaitForSeconds(1f);

        //audio
        _cache = Instantiate(Dunk, racer.transform.position, Quaternion.identity);
        _cache.transform.parent = racer.transform;
        Destroy(_cache, 2f);

        racer.GetComponent<Rigidbody>().AddExplosionForce(-10000f, racer.transform.position, 10f, 5f, ForceMode.Acceleration);
    }

    IEnumerator PickupSuperBoost(Collider racer)
    {
        // debugging
        if (racer.CompareTag("Player"))
        {
            Debug.Log($"<color=cyan>{racer.transform.name}: got 'Super Boost' pickup!</color>");
        }
        else
        {
            Debug.Log($"<color=yellow>{racer.transform.name}: got 'Super Boost' pickup!</color>");
        }

        //audio
        _cache = Instantiate(SuperBoost, racer.transform.position, Quaternion.identity);
        _cache.transform.parent = racer.transform;
        Destroy(_cache, 3f);

        // particles/effects

        // implementation
        racer.GetComponent<Rigidbody>().AddForce(racer.transform.forward * 1350000f);

        yield return new WaitForSeconds(2f);
    }
}
