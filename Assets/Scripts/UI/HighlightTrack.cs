using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighlightTrack : MonoBehaviour
{
    public GameObject Track1Border;
    public GameObject Track2Border;

    public GameObject Track1MainImage;
    public GameObject Track2MainImage;

    public GameObject Track1OutlineImage;
    public GameObject Track2OutlineImage;

    public GameObject TrackName;
    public Slider DifficultySlider;
    public Image DifficultyFill;

    public void MouseOverTrack1()
    {
        Track1Border.SetActive(true);
        Track2Border.SetActive(false);

        Track1MainImage.SetActive(true);
        Track2MainImage.SetActive(false);

        Track1OutlineImage.SetActive(true);
        Track2OutlineImage.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Chicane Central";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(0, 0, 255, 255);
        DifficultySlider.value = 3;
        DifficultyFill.color = new Color32(0, 255, 0, 255);
    }

    public void MouseOverTrack2()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(true);

        Track1MainImage.SetActive(false);
        Track2MainImage.SetActive(true);

        Track1OutlineImage.SetActive(false);
        Track2OutlineImage.SetActive(true);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Slip 'n Slide";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 0, 255);
        DifficultySlider.value = 8;
        DifficultyFill.color = new Color32(255, 0, 0, 255);
    }
}
