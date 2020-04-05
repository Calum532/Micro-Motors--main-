using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class RaceTimer_TimeTrial4 : MonoBehaviour
{
    private float countdownTimer = 3;
    public static float cTimer;
    private bool raceTimer = false;

    public static bool finished;
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;
    public static float RawTime;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public GameObject CountdownContainer;

    bool raceStarted = false;
    GameObject Player;

    private void Start()
    {
        CountdownContainer.SetActive(true);
        cTimer = countdownTimer;
        RawTime = 0;
        MinuteCount = 0;
        SecondCount = 0;
        MilliCount = 0;
    }

    void Update()
    {
        //if player has chosen a vehicle
        if (ChooseRacer_TimeTrial.RacerChosen)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
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

            //Start lap timer
            if (finished == false & raceTimer == true)
            {
                MilliCount += Time.deltaTime * 10;
                RawTime += Time.deltaTime;
                MilliDisplay = MilliCount.ToString("F0");
                MilliBox.GetComponent<TextMeshProUGUI>().text = "" + MilliDisplay;

                if (MilliCount >= 9)
                {
                    MilliCount = 0;
                    SecondCount += 1;
                }

                if (SecondCount <= 9)
                {
                    SecondBox.GetComponent<TextMeshProUGUI>().text = "0" + SecondCount + ".";
                }
                else
                {
                    SecondBox.GetComponent<TextMeshProUGUI>().text = "" + SecondCount + ".";
                }

                if (SecondCount >= 60)
                {
                    SecondCount = 0;
                    MinuteCount += 1;
                }

                if (MinuteCount <= 9)
                {
                    MinuteBox.GetComponent<TextMeshProUGUI>().text = "0" + MinuteCount + ":";
                }
                else
                {
                    MinuteBox.GetComponent<TextMeshProUGUI>().text = "" + MinuteCount + ":";
                }

                if (raceStarted)
                {
                    Player.GetComponent<CarUserControl>().enabled = true;
                    Player.GetComponent<PlayerSpeed>().enabled = true;
                }
                else
                {
                    Player.GetComponent<CarUserControl>().enabled = false;
                    Player.GetComponent<PlayerSpeed>().enabled = false;
                }
            }
        }
    }
}
