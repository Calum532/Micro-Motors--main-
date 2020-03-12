using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAICar : MonoBehaviour
{
    public float aiMagnitudeSpeed;
    public double aiMphSpeed;
    private float resetCountdown = 5;
    public GameObject aiWaypointTargetObject;

    // Update is called once per frame
    void Update()
    {
        aiMagnitudeSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        aiMphSpeed = aiMagnitudeSpeed * 2.222;

        if (aiMphSpeed < 5)
        {
            Debug.Log("starting countdown");
            resetCountdown -= Time.deltaTime;
            if(resetCountdown <= 0)
            {
                Debug.Log("reseting racer");
                transform.position = aiWaypointTargetObject.transform.position;
                transform.rotation = aiWaypointTargetObject.transform.rotation;
                resetCountdown = 5;
            }
        }
        else if(aiMphSpeed > 5)
        {
            resetCountdown = 5;
        }
    }
}
