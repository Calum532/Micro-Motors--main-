using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighlightTrack : MonoBehaviour
{
    public GameObject Track1Border;
    public GameObject Track2Border;
    public GameObject Track3Border;
    public GameObject Track4Border;
    public GameObject TrackRandomBorder;

    public GameObject Track1MainImage;
    public GameObject Track2MainImage;
    public GameObject Track3MainImage;
    public GameObject Track4MainImage;
    public GameObject TrackRandomMainImage;

    public GameObject Track1OutlineImage;
    public GameObject Track2OutlineImage;
    public GameObject Track3OutlineImage;
    public GameObject Track4OutlineImage;
    public GameObject TrackRandomOutlineImage;

    public GameObject TrackName;
    public GameObject DifficultyText;
    public Slider DifficultySlider;
    public Image DifficultyFill;


    public void MouseOverTrack1()
    {
        Track1Border.SetActive(true);
        Track2Border.SetActive(false);
        Track3Border.SetActive(false);
        Track4Border.SetActive(false);
        TrackRandomBorder.SetActive(false);

        Track1MainImage.SetActive(true);
        Track2MainImage.SetActive(false);
        Track3MainImage.SetActive(false);
        Track4MainImage.SetActive(false);
        TrackRandomMainImage.SetActive(false);

        Track1OutlineImage.SetActive(true);
        Track2OutlineImage.SetActive(false);
        Track3OutlineImage.SetActive(false);
        Track4OutlineImage.SetActive(false);
        TrackRandomOutlineImage.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Chicane Jungle";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(0, 255, 0, 255);
        DifficultySlider.value = 2;
        DifficultyFill.color = new Color32(0, 255, 0, 255);
        DifficultyText.GetComponent<TextMeshProUGUI>().text = "2/10";
    }

    public void MouseOverTrack2()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(true);
        Track3Border.SetActive(false);
        Track4Border.SetActive(false);
        TrackRandomBorder.SetActive(false);

        Track1MainImage.SetActive(false);
        Track2MainImage.SetActive(true);
        Track3MainImage.SetActive(false);
        Track4MainImage.SetActive(false);
        TrackRandomMainImage.SetActive(false);

        Track1OutlineImage.SetActive(false);
        Track2OutlineImage.SetActive(true);
        Track3OutlineImage.SetActive(false);
        Track4OutlineImage.SetActive(false);
        TrackRandomOutlineImage.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Slip 'n Slide";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 0, 255);
        DifficultySlider.value = 4;
        DifficultyFill.color = new Color32(255, 255, 0, 255);
        DifficultyText.GetComponent<TextMeshProUGUI>().text = "4/10";
    }

    public void MouseOverTrack3()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(false);
        Track3Border.SetActive(true);
        Track4Border.SetActive(false);
        TrackRandomBorder.SetActive(false);

        Track1MainImage.SetActive(false);
        Track2MainImage.SetActive(false);
        Track3MainImage.SetActive(true);
        Track4MainImage.SetActive(false);
        TrackRandomMainImage.SetActive(false);

        Track1OutlineImage.SetActive(false);
        Track2OutlineImage.SetActive(false);
        Track3OutlineImage.SetActive(true);
        Track4OutlineImage.SetActive(false);
        TrackRandomOutlineImage.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Birthday Bonza";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(255, 0, 0, 255);
        DifficultySlider.value = 6;
        DifficultyFill.color = new Color32(255, 128, 0, 255);
        DifficultyText.GetComponent<TextMeshProUGUI>().text = "6/10";
    }

    public void MouseOverTrack4()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(false);
        Track3Border.SetActive(false);
        Track4Border.SetActive(true);
        TrackRandomBorder.SetActive(false);

        Track1MainImage.SetActive(false);
        Track2MainImage.SetActive(false);
        Track3MainImage.SetActive(false);
        Track4MainImage.SetActive(true);
        TrackRandomMainImage.SetActive(false);

        Track1OutlineImage.SetActive(false);
        Track2OutlineImage.SetActive(false);
        Track3OutlineImage.SetActive(false);
        Track4OutlineImage.SetActive(true);
        TrackRandomOutlineImage.SetActive(false);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Out of Order";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(125, 0, 255, 255);
        DifficultySlider.value = 8;
        DifficultyFill.color = new Color32(255, 0, 0, 255);
        DifficultyText.GetComponent<TextMeshProUGUI>().text = "8/10";
    }

    public void MouseOverTrackRandom()
    {
        Track1Border.SetActive(false);
        Track2Border.SetActive(false);
        Track3Border.SetActive(false);
        Track4Border.SetActive(false);
        TrackRandomBorder.SetActive(true);

        Track1MainImage.SetActive(false);
        Track2MainImage.SetActive(false);
        Track3MainImage.SetActive(false);
        Track4MainImage.SetActive(false);
        TrackRandomMainImage.SetActive(true);

        Track1OutlineImage.SetActive(false);
        Track2OutlineImage.SetActive(false);
        Track3OutlineImage.SetActive(false);
        Track4OutlineImage.SetActive(false);
        TrackRandomOutlineImage.SetActive(true);

        FindObjectOfType<AudioManager>().Play("Click");
        TrackName.GetComponent<TextMeshProUGUI>().text = "Random Track";
        TrackName.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
        DifficultySlider.value = 0;
        DifficultyFill.color = new Color32(255, 255, 255, 255);
        DifficultyText.GetComponent<TextMeshProUGUI>().text = "?/10";
    }
}
