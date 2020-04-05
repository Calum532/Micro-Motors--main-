using UnityEngine;
using TMPro;

public class LoadLapTime4 : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject BestMinDisplay;
    public GameObject BestSecDisplay;
    public GameObject BestMilliDisplay;

    void Start()
    {
        if (PlayerPrefs.GetFloat("RawTime4") == 0)
        {
            PlayerPrefs.SetInt("BestMinSave4", 2);
            PlayerPrefs.SetInt("BestSecSave4", 0);
            PlayerPrefs.SetFloat("BestMilliSave4", 0);
            PlayerPrefs.SetFloat("RawTime4", 120);
        }

        MinCount = PlayerPrefs.GetInt("BestMinSave4");
        SecCount = PlayerPrefs.GetInt("BestSecSave4");
        MilliCount = PlayerPrefs.GetFloat("BestMilliSave4");

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
