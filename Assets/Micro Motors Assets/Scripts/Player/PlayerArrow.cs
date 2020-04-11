using UnityEngine;

public class PlayerArrow : MonoBehaviour
{
    [Header("Objects:")]
    public GameObject Arrow;
    public GameObject WaypointTargetObject;

    [Header("Settings")]
    public float lerpSpeed;

    //public GameObject WrongWayUI;

    private bool isActive = true;

    void Awake()
    {
        if (lerpSpeed <= 0)
        {
            lerpSpeed = 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Arrow.transform.rotation = Quaternion.Lerp(Arrow.transform.rotation, WaypointTargetObject.transform.rotation, lerpSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isActive)
            {
                Arrow.SetActive(false);
                isActive = false;
            }
            else
            {
                Arrow.SetActive(true);
                isActive = true;
            }
        }
    }
}
