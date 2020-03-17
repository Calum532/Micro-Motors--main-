using UnityEngine;

public class VehicleCamCollision : MonoBehaviour
{
    [Header("Settings")]
    public float minDistance = 0.3f;
    public float maxDistance = 4.0f;
    public float smooth = 10.0f;
    public float distance;
    public float dis_ray;

    private Vector3 _dollyDir;

    // Use this for initialization
    void Awake()
    {
        _dollyDir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 desiredCameraPos = transform.parent.TransformPoint(_dollyDir * maxDistance);
        RaycastHit hit;

        if (Physics.Linecast(transform.parent.position, desiredCameraPos, out hit))
        {
            distance = Mathf.Clamp((hit.distance * dis_ray), minDistance, maxDistance);

        }
        else
        {
            distance = maxDistance;
        }

        transform.localPosition = Vector3.Lerp(transform.localPosition, _dollyDir * distance, Time.deltaTime * smooth);
    }
}
