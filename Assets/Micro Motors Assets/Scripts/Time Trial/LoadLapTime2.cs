using UnityEngine;
using TMPro;

public class LoadLapTime2 : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject BestMinDisplay;
    public GameObject BestSecDisplay;
    public GameObject BestMilliDisplay;

    void Start()
    {
        if (PlayerPrefs.GetFloat("RawTime2") == 0)
        {
            PlayerPrefs.SetInt("BestMinSave2", 2);
            PlayerPrefs.SetInt("BestSecSave2", 30);
            PlayerPrefs.SetFloat("BestMilliSave2", 0);
            PlayerPrefs.SetFloat("RawTime2", 150);
        }

        MinCount = PlayerPrefs.GetInt("BestMinSave2");
        SecCount = PlayerPrefs.GetInt("BestSecSave2");
        MilliCount = PlayerPrefs.GetFloat("BestMilliSave2");

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
