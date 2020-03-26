using UnityEngine;
using TMPro;

public class LoadLapTime3 : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject BestMinDisplay;
    public GameObject BestSecDisplay;
    public GameObject BestMilliDisplay;

    void Start()
    {
        if (PlayerPrefs.GetFloat("RawTime3") == 0)
        {
            PlayerPrefs.SetInt("BestMinSave3", 4);
            PlayerPrefs.SetInt("BestSecSave3", 0);
            PlayerPrefs.SetFloat("BestMilliSave3", 0);
            PlayerPrefs.SetFloat("RawTime3", 240);
        }

        MinCount = PlayerPrefs.GetInt("BestMinSave3");
        SecCount = PlayerPrefs.GetInt("BestSecSave3");
        MilliCount = PlayerPrefs.GetFloat("BestMilliSave3");

        if (MinCount <= 9)
        {
            BestMinDisplay.GetComponent<TextMeshProUGUI>().text = "0" + MinCount + ":";
        }
        else
        {
            BestMinDisplay.GetComponent<TextMeshProUGUI>().text = "" + MinCount + ":";
        }

        if (SecCount <= 9)
        {
            BestSecDisplay.GetComponent<TextMeshProUGUI>().text = "0" + SecCount + ".";
        }
        else
        {
            BestSecDisplay.GetComponent<TextMeshProUGUI>().text = "" + SecCount + ".";
        }

        BestMilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + MilliCount.ToString("F0");
    }
}
