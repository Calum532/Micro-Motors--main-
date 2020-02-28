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
            SpeedUI.GetComponent<TextMeshProUGUI>().text = mphSpeed.ToString("F0") + "mph";
        }
    }
}
