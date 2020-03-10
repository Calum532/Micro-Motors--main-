using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete : MonoBehaviour
{
    public GameObject RaceCompleteUI;
    public GameObject GameUI;
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject BestMinuteDisplay;
    public GameObject BestSecondDisplay;
    public GameObject BestMilliDisplay;
    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public GameObject RaceCompleteCam;
    public GameObject FrontCam;

    public int playerLapsDone = 1;

    public float RawTime;
    public int firstPlaceWinnings = 500;
    public int secondPlaceWinnings = 300;
    public int thirdPlaceWinnings = 100;
    public GameObject winningsDisplay;

    GameObject Player;
    GameObject AIRC;
    GameObject AIUFO;
    GameObject AITaxi;
    GameObject AITank;
    GameObject AITruck;
    GameObject AIDozer;
    GameObject AIMonster;
    GameObject AISkyCar;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerLapsDone += 1;

            if (playerLapsDone >= 1) //race complete
            {
                PauseMenu.gameIsPaused = true;
                Player.GetComponent<CarUserControl>().enabled = false;
                Player.GetComponent<CarAIControl>().enabled = true;
                RaceCompleteUI.SetActive(true);
                GameUI.SetActive(false);
                RaceTimer.finished = true;
                RaceCompleteCam.SetActive(true);
                FrontCam.SetActive(false);

                if(PlayerPos.playerPosition == 1)
                {
                    GlobalCash.TotalCredits += firstPlaceWinnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + firstPlaceWinnings;
                    PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
                }
                else if (PlayerPos.playerPosition == 2)
                {
                    GlobalCash.TotalCredits += secondPlaceWinnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + secondPlaceWinnings;
                    PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
                }
                else if (PlayerPos.playerPosition == 3)
                {
                    GlobalCash.TotalCredits += thirdPlaceWinnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + thirdPlaceWinnings;
                    PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
                }
                else
                {
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $0";
                }
            }

            LapCounter.GetComponent<TextMeshProUGUI>().text = "" + playerLapsDone + "/3";
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
