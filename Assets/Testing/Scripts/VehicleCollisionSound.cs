using System.Collections;
using UnityEngine;

public class VehicleCollisionSound : MonoBehaviour
{
    [Header("Collision Sounds")]
    public AudioClip[] collisionImpacts;

    [Header("Settings")]
    public float playAfter;
    public float deleteAfter;

    private AudioSource _source;
    private GameObject _this;

    void Awake()
    {
        if (deleteAfter <= 0f)
        {
            deleteAfter = 1f;
        }
        _source = GetComponent<AudioSource>();
        _this = gameObject;
    }

    void Start()
    {
        _source.pitch = (Random.Range(0.95f, 1.05f));
        _source.clip = collisionImpacts[Random.Range(0, collisionImpacts.Length)];
        StartCoroutine(ExecuteAfterTime(playAfter));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        _source.PlayOneShot(_source.clip);
        Destroy(_this, deleteAfter);
    }
}
