using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerSpeed : MonoBehaviour
{
    public static float magnitudeSpeed;
    public static double mphSpeed;
    public bool validReset = false;
    private float resetCountdown = 4;

    public GameObject SpeedUI;
    public GameObject WaypointTargetObject;
    public GameObject Reset_UI;

    // Update is called once per frame
    void Update()
    {
        magnitudeSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        mphSpeed = magnitudeSpeed * 2.222;
        SpeedUI.GetComponent<TextMeshProUGUI>().text = mphSpeed.ToString("F0") + "mph";

        if (mphSpeed < 5)
        {
            resetCountdown -= Time.deltaTime;
            if (resetCountdown <= 0)
            {
                Reset_UI.GetComponent<TextMeshProUGUI>().text = "Press [E] to reset racer";
                validReset = true;
                if (Input.GetKeyDown(KeyCode.E) && validReset == true)
                {
                    transform.position = WaypointTargetObject.transform.position;
                    transform.rotation = WaypointTargetObject.transform.rotation;
                    Reset_UI.GetComponent<TextMeshProUGUI>().text = "";
                    resetCountdown = 4;
                    validReset = false;
                }
            }
        }
        else if (mphSpeed > 5)
        {
            resetCountdown = 4;
            validReset = false;
            Reset_UI.GetComponent<TextMeshProUGUI>().text = "";
        }
    }
}
