using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class LapComplete_TimeTrial3 : MonoBehaviour
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
            if (RaceTimer_TimeTrial3.RawTime <= RawTime)
            {
                if (RaceTimer_TimeTrial3.MinuteCount <= 9)
                {
                    BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer_TimeTrial3.MinuteCount + ":";
                }
                else
                {
                    BestMinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial3.MinuteCount + ":";
                }

                if (RaceTimer_TimeTrial3.SecondCount <= 9)
                {
                    BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + RaceTimer_TimeTrial3.SecondCount + ".";
                }
                else
                {
                    BestSecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial3.SecondCount + ".";
                }

                BestMilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + RaceTimer_TimeTrial3.MilliCount.ToString("F0");

                PauseMenu.gameIsPaused = true;
                Player.GetComponent<CarUserControl>().enabled = false;
                Player.GetComponent<CarAIControl>().enabled = true;
                NewRecordUI.SetActive(true);
                GameUI.SetActive(false);
                RaceTimer_TimeTrial3.finished = true;
                RaceCompleteCam.SetActive(true);
                FrontCam.SetActive(false);
                FindObjectOfType<AudioManager>().Play("You did it!");
                GlobalCash.TotalCredits += 500;
                PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCredits);
            }

            PlayerPrefs.SetInt("BestMinSave3", RaceTimer_TimeTrial3.MinuteCount);
            PlayerPrefs.SetInt("BestSecSave3", RaceTimer_TimeTrial3.SecondCount);
            PlayerPrefs.SetFloat("BestMilliSave3", RaceTimer_TimeTrial3.MilliCount);
            PlayerPrefs.SetFloat("RawTime3", RaceTimer_TimeTrial3.RawTime);

            RaceTimer_TimeTrial3.MinuteCount = 0;
            RaceTimer_TimeTrial3.SecondCount = 0;
            RaceTimer_TimeTrial3.MilliCount = 0;
            RaceTimer_TimeTrial3.RawTime = 0;
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
