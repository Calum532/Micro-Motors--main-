using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject menuUI;
    public GameObject raceTypeUI;
    public GameObject SR_raceTrackUI;
    public GameObject AI_raceTrackUI;
    public GameObject TimeTrial_TrackUI;
    public GameObject settingsUI;

    public void ResetCredits() // reset credits total to 0
    {
        PlayerPrefs.DeleteAll();
    }

    public void RaceTypeSelect()
    {
        raceTypeUI.SetActive(true);
        menuUI.SetActive(false);
    }

    public void SR_RaceTrackSelect() //standard race selected
    {
        raceTypeUI.SetActive(false);
        SR_raceTrackUI.SetActive(true);
    }

    public void TimeTrial_Select() //Time Trial selected
    {
        raceTypeUI.SetActive(false);
        TimeTrial_TrackUI.SetActive(true);
    }

    public void AI_RaceTrackSelect() //AI race selected
    {
        raceTypeUI.SetActive(false);
        AI_raceTrackUI.SetActive(true);
    }

    public void DisplaySettings()
    {
        settingsUI.SetActive(true);
        menuUI.SetActive(false);
    }

    public void Back()
    {
        menuUI.SetActive(true);
        raceTypeUI.SetActive(false);
        settingsUI.SetActive(false);
        SR_raceTrackUI.SetActive(false);
        TimeTrial_TrackUI.SetActive(false);
        AI_raceTrackUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
