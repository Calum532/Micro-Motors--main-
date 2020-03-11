using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class SpeedInterface : MonoBehaviour
{
    public static float magnitudeSpeed;
    public static double mphSpeed;

    public GameObject SpeedUI;
    GameObject Player;

    void Update()
    {
        //if player has chosen a vehicle
        if (ChooseRacer_testdrive.RacerChosen)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            Player.GetComponent<CarUserControl>().enabled = true;

            magnitudeSpeed = Player.GetComponent<Rigidbody>().velocity.magnitude;
            mphSpeed = magnitudeSpeed * 2.222;
            // colour stuff
            SpeedUI.GetComponent<TextMeshProUGUI>().color = Color.Lerp(SpeedUI.GetComponent<TextMeshProUGUI>().color, mphSpeed >= 30 ? Color.yellow : Color.white, Time.deltaTime * 2f);
            SpeedUI.GetComponent<TextMeshProUGUI>().color = Color.Lerp(SpeedUI.GetComponent<TextMeshProUGUI>().color, mphSpeed >= 90 ? Color.red : Color.white, Time.deltaTime * 2f);
            //
            SpeedUI.GetComponent<TextMeshProUGUI>().text = mphSpeed.ToString("F0") + "mph";
        }
    }
}