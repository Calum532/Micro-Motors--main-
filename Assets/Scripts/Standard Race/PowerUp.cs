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

    public float respawnDuration = 5f;
    public float effectDuration = 10f;
    public float grow;
    public float rotateSpeed;

    private int randomNum;

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

            Instantiate(pickupEffect, transform.position, transform.rotation);
            StartCoroutine(respawnCountdown());

            randomNum = UnityEngine.Random.Range(0, 1);
            Debug.Log("Random number generated: " + randomNum);

            if (randomNum == 0)
            {
                StartCoroutine(PickupShrink(other));
            }
            else if (randomNum == 1)
            {
                StartCoroutine(PickupGrow(other));
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
        FindObjectOfType<AudioManager>().Play("Debuff");
        racer.transform.localScale /= grow;

        yield return new WaitForSeconds(effectDuration);

        racer.transform.localScale *= grow;
        FindObjectOfType<AudioManager>().Play("Buff");
    }
}
