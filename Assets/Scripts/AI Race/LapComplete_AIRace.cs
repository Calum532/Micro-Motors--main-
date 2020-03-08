using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete_AIRace : MonoBehaviour
{
    public GameObject RaceCompleteUI;
    public GameObject GameUI;
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject LapCounter;
    public GameObject RaceCompleteCam;
    public GameObject FrontCam;

    public int playerLapsDone = 1;

    public float Winnings;
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
                Player.GetComponent<CarAIControl>().enabled = true;
                RaceCompleteUI.SetActive(true);
                GameUI.SetActive(false);
                RaceTimer.finished = true;
                RaceCompleteCam.SetActive(true);
                FrontCam.SetActive(false);

                if(PlayerPos.playerPosition == 1)
                {
                    Winnings = PlaceBet.betAmount * 3f;
                    GlobalCash.TotalCredits += Winnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + Winnings;
                    PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
                }
                else if (PlayerPos.playerPosition == 2)
                {
                    Winnings = PlaceBet.betAmount * 2f;
                    GlobalCash.TotalCredits += Winnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + Winnings;
                    PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
                }
                else if (PlayerPos.playerPosition == 3)
                {
                    Winnings = PlaceBet.betAmount * 1.5f;
                    GlobalCash.TotalCredits += Winnings;
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $" + Winnings;
                    PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
                }
                else
                {
                    winningsDisplay.GetComponent<TextMeshProUGUI>().text = "Winnings: $0";
                }
            }

            LapCounter.GetComponent<TextMeshProUGUI>().text = "" + playerLapsDone + "/1";
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
