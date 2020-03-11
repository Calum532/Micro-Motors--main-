using System.Collections;
using UnityEngine;

public class VehicleFlip : MonoBehaviour
{
    [Header("Settings")] public int upForce;
    public int rotAmount;

    private Vector3 _rot;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponentInParent<Rigidbody>(); // rigidbody component caching
    }

    void FixedUpdate()
    {
        _rot = new Vector3(Random.Range(0, rotAmount), 0, 0); // random rotation amount between 0 and rotAmount
    }

    void OnTriggerEnter(Collider other)
    {
        // ui notice?
    }

    void OnTriggerStay(Collider other)
    {
        RequireInput();
    }

    private void RequireInput()
    {
        if (Input.GetKeyDown(KeyCode.F)) // if f pressed
        {
            _rb.velocity += Vector3.up * upForce; // force player upwards
            StartCoroutine(ExecuteAfterTime(1));
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        // remove ui notice
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay     
        _rb.transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, _rot, Time.deltaTime * 2f); // rotation
    }
}
