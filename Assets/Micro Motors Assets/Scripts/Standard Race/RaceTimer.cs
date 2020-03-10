using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class RaceTimer : MonoBehaviour
{
    public float countdownTimer = 3;
    public static float cTimer;
    public bool raceTimer = false;

    public static bool finished;
    public static float magnitudeSpeed;
    public static double mphSpeed;

    public GameObject CountdownContainer;
    public GameObject SpeedUI;

    public bool raceStarted = false;
    GameObject[] AICars;
    GameObject Player;

    private void Start()
    {
        cTimer = countdownTimer;
        finished = false;
    }

    void Update()
    {
        //if player has chosen a vehicle
        if (ChooseRacer.RacerChosen)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            AICars = GameObject.FindGameObjectsWithTag("AICar");
            Player.GetComponent<CarUserControl>().enabled = false;

            magnitudeSpeed = Player.GetComponent<Rigidbody>().velocity.magnitude;
            mphSpeed = magnitudeSpeed * 2.222;
            SpeedUI.GetComponent<TextMeshProUGUI>().text = mphSpeed.ToString("F0") + "mph";

            //start 3 second race countdown
            if (raceTimer == false)
            {
                CountdownContainer.SetActive(true);
                PauseMenu.gameIsPaused = true;
                cTimer -= Time.deltaTime;
            }

            //Race starts
            if (cTimer <= 0f)
            {
                FindObjectOfType<AudioManager>().Play("Race1Music");
                PauseMenu.gameIsPaused = false;
                raceTimer = true;
                raceStarted = true;
                cTimer = 3;
            }

            //Enable racer control
            if (finished == false & raceTimer == true)
            {
                if (raceStarted)
                {
                    Player.GetComponent<CarUserControl>().enabled = true;

                    foreach (GameObject car in AICars)
                    {
                        car.GetComponent<CarAIControl>().enabled = true;
                    }
                }
                else if(!raceStarted)
                {
                    Player.GetComponent<CarUserControl>().enabled = false;
                    foreach (GameObject car in AICars)
                    {
                        car.GetComponent<CarAIControl>().enabled = false;
                    }
                }
            }
        }
    }
}
