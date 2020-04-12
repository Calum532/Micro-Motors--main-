using UnityEngine;

public class ResetAICar : MonoBehaviour
{
    public float aiMagnitudeSpeed;
    public double aiMphSpeed;
    private float resetCountdown = 5;
    public GameObject aiWaypointTargetObject;

    [Header("Particles/World Objects:")]
    public GameObject explosionParticle;
    public GameObject resetAudio;

    // caching
    private GameObject _Cache;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        aiMagnitudeSpeed = _rb.velocity.magnitude;
        aiMphSpeed = aiMagnitudeSpeed * 2.222;

        if (aiMphSpeed < 5)
        {
            resetCountdown -= Time.deltaTime;
            if(resetCountdown <= 0)
            {
                //explosion wow.
                _Cache = Instantiate(explosionParticle, transform.position, Quaternion.identity);
                Destroy(_Cache, 3f);
                Reset();
                resetCountdown = 5;
            }
        }
        else if(aiMphSpeed > 5)
        {
            resetCountdown = 5;
        }
    }

    public void Reset()
    {
        Debug.Log($"<color=yellow>{transform.name}: Resetting</color>");
        
        transform.position = aiWaypointTargetObject.transform.position;
        transform.rotation = aiWaypointTargetObject.transform.rotation;
        //audio somehow
        _Cache = Instantiate(resetAudio, transform.position, Quaternion.identity);
        _Cache.transform.parent = transform;
        Destroy(_Cache, 1f);
    }
}
