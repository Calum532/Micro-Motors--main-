using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject explosionEffect;
    public float deathDelay = 1f;
    //public float releaseDelay = 3f;
    //public Collider coll;
    GameObject player;

    //[SerializeField] private Transform playerT;
    [SerializeField] private Transform respawnPoint;

    private void Start()
    {
        //coll = GetComponent<Collider>();
        //coll.isTrigger = true;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        Debug.Log("Respawn - Respawning Car");
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("Explosion");
        //player.enabled = false;
        //player.attachedRigidbody.useGravity = false;
        yield return new WaitForSeconds(deathDelay); //Wait 1 second
        player.transform.position = respawnPoint.transform.position;
        //col.enabled = true;
        //yield return new WaitForSeconds(releaseDelay); //wait 3 seconds
        //col.attachedRigidbody.useGravity = true;
    }
}
