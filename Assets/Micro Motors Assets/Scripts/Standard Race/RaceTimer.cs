using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceTimer : MonoBehaviour
{
    public float countdownTimer = 3;
    public static float cTimer;
    public bool raceTimer = false;
    public static bool finished;

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
                PauseMenu.gameIsPaused = false;
                raceTimer = true;
                raceStarted = true;
                cTimer = 3;
            }

            //Enable racer control and reset vehicle on track scripts
            if (finished == false & raceTimer == true)
            {
                if (raceStarted)
                {
                    Player.GetComponent<CarUserControl>().enabled = true;
                    Player.GetComponent<PlayerSpeed>().enabled = true;

                    foreach (GameObject car in AICars)
                    {
                        car.GetComponent<CarAIControl>().enabled = true;
                        car.GetComponent<ResetAICar>().enabled = true;
                    }
                }
                else if(!raceStarted)
                {
                    Player.GetComponent<CarUserControl>().enabled = false;
                    Player.GetComponent<PlayerSpeed>().enabled = false;

                    foreach (GameObject car in AICars)
                    {
                        car.GetComponent<CarAIControl>().enabled = false;
                        car.GetComponent<ResetAICar>().enabled = false;
                    }
                }
            }
        }
    }
}
