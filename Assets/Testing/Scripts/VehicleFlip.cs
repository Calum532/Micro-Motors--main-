using UnityEngine;

public class VehicleFlip : MonoBehaviour
{
    [Header("Settings")]
    public float WaitTime = 3f;           // time to wait before self righting
    public float VelocityThreshold = 1f;  // the velocity below which the car is considered stationary for self-righting
    public float ShoveAmount = 99999f;    // amount to shove slightly forward to aid in resetting

    private float _LastOkTime; // the last time that the car was in an OK state
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // is the car is the right way up OR is going faster than the threshhold
        if (transform.up.y > 0f || _rb.velocity.magnitude > VelocityThreshold)
        {
            _LastOkTime = Time.time; // we are ok :)
        }
        // if car is right way up, AND is slower than the threshhold AND we get input from player
        if (transform.up.y > 0f && _rb.velocity.magnitude < VelocityThreshold && Input.GetKeyDown(KeyCode.F))
        {
            // display ui
            RightVehicle(); // right the vehicle
        }
        // if we're not ok :( for longer than the wait time
        if (Time.time > _LastOkTime + WaitTime)
        {
            // display ui
            RightVehicle(); // right the vehicle
        }
    }

    // put the vehicle back the right way up:
    private void RightVehicle()
    {
        // set the correct orientation for the car, lift it off the ground a little and shove it slightly forward
        transform.position += Vector3.up;
        transform.rotation = Quaternion.LookRotation(transform.forward);
        _rb.AddForce(_rb.transform.forward * ShoveAmount);
    }
}
