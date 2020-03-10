using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighlightGamemode : MonoBehaviour
{
    public GameObject SRBorder;
    public GameObject TTBorder;
    public GameObject AIRBorder;

    public GameObject SRImage;
    public GameObject TTImage;
    public GameObject AIRImage;
    public GameObject DefaultImage;

    public GameObject GamemodeText;


    public void MouseOverSR()
    {
        SRBorder.SetActive(true);
        TTBorder.SetActive(false);
        AIRBorder.SetActive(false);

        DefaultImage.SetActive(false);
        SRImage.SetActive(true);
        TTImage.SetActive(false);
        AIRImage.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        GamemodeText.GetComponent<TextMeshProUGUI>().text = "Standard Race: Race against seven other racers and be the first to complete 3 laps! \n \n 1st: $500 / 2nd: $300 / 3rd: $100";
    }

    public void MouseOverTT()
    {
        SRBorder.SetActive(false);
        TTBorder.SetActive(true);
        AIRBorder.SetActive(false);

        DefaultImage.SetActive(false);
        SRImage.SetActive(false);
        TTImage.SetActive(true);
        AIRImage.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        GamemodeText.GetComponent<TextMeshProUGUI>().text = "Time Trial: Race against clock to set the fastest lap time! \n \n New lap record: $500";
    }

    public void MouseOverAIR()
    {
        SRBorder.SetActive(false);
        TTBorder.SetActive(false);
        AIRBorder.SetActive(true);

        DefaultImage.SetActive(false);
        SRImage.SetActive(false);
        TTImage.SetActive(false);
        AIRImage.SetActive(true);

        FindObjectOfType<AudioManager>().Play("Click");
        GamemodeText.GetComponent<TextMeshProUGUI>().text = "AI Race: Best your hard earned credits on one of your unlocked racers and watch it race to be the first to complete the lap! \n \n 1st: 3:1 / 2nd 2:1 / 3rd: 1.5:1";
    }
}
