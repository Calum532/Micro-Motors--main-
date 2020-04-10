using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class SpeedInterface : MonoBehaviour
{
    public static float magnitudeSpeed;
    public static double mphSpeed;

    public GameObject SpeedUI;
    private TextMeshProUGUI _TMP_speed;

    private GameObject Player;
    private Rigidbody _rb;


    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _rb = Player.GetComponent<Rigidbody>();
        _TMP_speed = SpeedUI.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        //if player has chosen a vehicle
        if (ChooseRacer_testdrive.RacerChosen)
        {
            Player.GetComponent<CarUserControl>().enabled = true;

            magnitudeSpeed = _rb.velocity.magnitude;
            mphSpeed = magnitudeSpeed * 2.222;
            // colour stuff
            _TMP_speed.color = Color.Lerp(_TMP_speed.color, mphSpeed >= 30 ? Color.yellow : Color.white, Time.deltaTime * 2f);
            _TMP_speed.color = Color.Lerp(_TMP_speed.color, mphSpeed >= 90 ? Color.red : Color.white, Time.deltaTime * 2f);
            //
            _TMP_speed.text = mphSpeed.ToString("F0") + "mph";
        }
    }
}