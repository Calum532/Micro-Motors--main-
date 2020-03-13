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
    public GameObject press_F_To_Reset_UI;

    private void Start()
    {
        press_F_To_Reset_UI.SetActive(false);
    }

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
                press_F_To_Reset_UI.SetActive(true);
                validReset = true;
                if (Input.GetKeyDown(KeyCode.F) && validReset == true)
                {
                    transform.position = WaypointTargetObject.transform.position;
                    transform.rotation = WaypointTargetObject.transform.rotation;
                    press_F_To_Reset_UI.SetActive(false);
                    resetCountdown = 4;
                    validReset = false;
                }
            }
        }
        else if (mphSpeed > 5)
        {
            resetCountdown = 4;
            validReset = false;
        }
    }
}
