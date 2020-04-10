using UnityEngine;

public class ResetAICar : MonoBehaviour
{
    public float aiMagnitudeSpeed;
    public double aiMphSpeed;
    private float resetCountdown = 5;
    public GameObject aiWaypointTargetObject;

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
    }
}
