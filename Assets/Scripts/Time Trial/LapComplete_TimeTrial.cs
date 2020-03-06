using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete_TimeTrial : MonoBehaviour
{
    public GameObject NewRecordUI;
    public GameObject GameUI;
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject BestMinuteDisplay;
    public GameObject BestSecondDisplay;
    public GameObject BestMilliDisplay;
    public GameObject RaceCompleteCam;
    public GameObject FrontCam;

    public float RawTime;

    GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (RaceTimer_TimeTrial.RawTime <= RawTime)
            {
                if (RaceTimer_TimeTrial.MinuteCount <= 9)
                {
                    BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer_TimeTrial.MinuteCount + ":";
                }
                else
                {
                    BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial.MinuteCount + ":";
                }

                if (RaceTimer_TimeTrial.SecondCount <= 9)
                {
                    BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer_TimeTrial.SecondCount + ".";
                }
                else
                {
                    BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial.SecondCount + ".";
                }

                BestMilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial.MilliCount.ToString("F0");

                PauseMenu.gameIsPaused = true;
                Player.GetComponent<CarUserControl>().enabled = false;
                Player.GetComponent<CarAIControl>().enabled = true;
                NewRecordUI.SetActive(true);
                GameUI.SetActive(false);
                RaceTimer_TimeTrial.finished = true;
                RaceCompleteCam.SetActive(true);
                FrontCam.SetActive(false);
                FindObjectOfType<AudioManager>().Play("You did it!");
                GlobalCash.TotalCredits += 500;
                PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCredits);
            }

            PlayerPrefs.SetInt("BestMinSave", RaceTimer_TimeTrial.MinuteCount);
            PlayerPrefs.SetInt("BestSecSave", RaceTimer_TimeTrial.SecondCount);
            PlayerPrefs.SetFloat("BestMilliSave", RaceTimer_TimeTrial.MilliCount);
            PlayerPrefs.SetFloat("RawTime", RaceTimer_TimeTrial.RawTime);

            RaceTimer_TimeTrial.MinuteCount = 0;
            RaceTimer_TimeTrial.SecondCount = 0;
            RaceTimer_TimeTrial.MilliCount = 0;
            RaceTimer_TimeTrial.RawTime = 0;
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
