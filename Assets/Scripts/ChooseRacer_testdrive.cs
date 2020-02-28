using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRacer_testdrive : MonoBehaviour
{
    public GameObject ChooseRacerUI;
    public GameObject GameUI;
    public GameObject FrontCam;
    public GameObject SkyCam;

    public GameObject PlayerRC;
    public GameObject PlayerUFO;
    public GameObject PlayerTaxi;
    public GameObject PlayerTank;
    public GameObject PlayerMonster;
    public GameObject PlayerTruck;
    public GameObject PlayerDozer;
    public GameObject PlayerSkyCar;

    public static bool RacerChosen = false;
    private int RandomNum;

    void Start()
    {
        RacerChosen = false;
        PauseMenu.gameIsPaused = true;
    }

    public void PickRC()
    {
            PlayerRC.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickTaxi()
    {
            PlayerTaxi.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickUFO()
    {
            PlayerUFO.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickTank()
    {
            PlayerTank.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickDozer()
    {
            PlayerDozer.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickTruck()
    {
            PlayerTruck.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickMonster()
    {
            PlayerMonster.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickSkyCar()
    {
            PlayerSkyCar.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
    }

    public void PickRandom()
    {
            RandomNum = UnityEngine.Random.Range(0, 7);

            if (RandomNum == 0)
            {
                    PickRC();
            }
            else if (RandomNum == 1)
            {
                    PickUFO();
            }
            else if (RandomNum == 2)
            {
                    PickTaxi();
            }
            else if (RandomNum == 3)
            {
                    PickMonster();
            }
            else if (RandomNum == 4)
            {
                    PickTank();
            }
            else if (RandomNum == 5)
            {
                    PickTruck();
            }
            else if (RandomNum == 6)
            {
                    PickDozer();
            }
            else if (RandomNum == 7)
            {
                    PickSkyCar();
            }
    }
}
