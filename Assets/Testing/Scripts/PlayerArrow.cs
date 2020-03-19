using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArrow : MonoBehaviour
{
    public GameObject Arrow;
    public GameObject WaypointTargetObject;
    bool isActive = true;
    //public GameObject WrongWayUI;

    // Update is called once per frame
    void Update()
    {
        Arrow.transform.LookAt(WaypointTargetObject.transform.position);
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
