using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete_TimeTrial4 : MonoBehaviour
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
            RawTime = PlayerPrefs.GetFloat("RawTime3");
            if (RaceTimer_TimeTrial4.RawTime <= RawTime)
            {
                if (RaceTimer_TimeTrial4.MinuteCount <= 9)
                {
                    BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer_TimeTrial4.MinuteCount + ":";
                }
                else
                {
                    BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial4.MinuteCount + ":";
                }

                if (RaceTimer_TimeTrial4.SecondCount <= 9)
                {
                    BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer_TimeTrial4.SecondCount + ".";
                }
                else
                {
                    BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial4.SecondCount + ".";
                }

                BestMilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial4.MilliCount.ToString("F0");

                PauseMenu.gameIsPaused = true;
                Player.GetComponent<CarUserControl>().enabled = false;
                Player.GetComponent<CarAIControl>().enabled = true;
                NewRecordUI.SetActive(true);
                GameUI.SetActive(false);
                RaceTimer_TimeTrial4.finished = true;
                RaceCompleteCam.SetActive(true);
                FrontCam.SetActive(false);
                FindObjectOfType<AudioManager>().Play("You did it!");
                GlobalCash.TotalCredits += 500;
                PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
            }

            PlayerPrefs.SetInt("BestMinSave4", RaceTimer_TimeTrial4.MinuteCount);
            PlayerPrefs.SetInt("BestSecSave4", RaceTimer_TimeTrial4.SecondCount);
            PlayerPrefs.SetFloat("BestMilliSave4", RaceTimer_TimeTrial4.MilliCount);
            PlayerPrefs.SetFloat("RawTime4", RaceTimer_TimeTrial4.RawTime);

            RaceTimer_TimeTrial4.MinuteCount = 0;
            RaceTimer_TimeTrial4.SecondCount = 0;
            RaceTimer_TimeTrial4.MilliCount = 0;
            RaceTimer_TimeTrial4.RawTime = 0;
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
