﻿using UnityEngine;
using TMPro;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject BestMinDisplay;
    public GameObject BestSecDisplay;
    public GameObject BestMilliDisplay;

    void Start()
    {
        if (PlayerPrefs.GetFloat("RawTime") == 0)
        {
            PlayerPrefs.SetInt("BestMinSave", 1);
            PlayerPrefs.SetInt("BestSecSave", 0);
            PlayerPrefs.SetFloat("BestMilliSave", 0);
            PlayerPrefs.SetFloat("RawTime", 60);
        }

        MinCount = PlayerPrefs.GetInt("BestMinSave");
        SecCount = PlayerPrefs.GetInt("BestSecSave");
        MilliCount = PlayerPrefs.GetFloat("BestMilliSave");

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
