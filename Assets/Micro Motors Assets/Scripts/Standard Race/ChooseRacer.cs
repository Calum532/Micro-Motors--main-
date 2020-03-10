using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRacer : MonoBehaviour
{
    public GameObject ChooseRacerUI;
    public GameObject GameUI;
    public GameObject FrontCam;
    public GameObject SkyCam;

    public GameObject RCCross;
    public GameObject UFOCross;
    public GameObject TaxiCross;
    public GameObject TankCross;
    public GameObject MonsterCross;
    public GameObject TruckCross;
    public GameObject DozerCross;
    public GameObject SkyCarCross;

    public GameObject PlayerRC;
    public GameObject PlayerUFO;
    public GameObject PlayerTaxi;
    public GameObject PlayerTank;
    public GameObject PlayerMonster;
    public GameObject PlayerTruck;
    public GameObject PlayerDozer;
    public GameObject PlayerSkyCar;

    public GameObject AIRC;
    public GameObject AIUFO;
    public GameObject AITaxi;
    public GameObject AITank;
    public GameObject AIMonster;
    public GameObject AITruck;
    public GameObject AIDozer;

    public GameObject SkyCarRC;
    public GameObject SkyCarUFO;
    public GameObject SkyCarTaxi;
    public GameObject SkyCarTank;
    public GameObject SkyCarMonster;
    public GameObject SkyCarTruck;
    public GameObject SkyCarDozer;

    public static bool RacerChosen = false;
    private int RandomNum;
    private bool validRacer = false;

    void Start()
    {
        RacerChosen = false;

        PauseMenu.gameIsPaused = true;

        if(Garage.RCOwned == true)
        {
            RCCross.SetActive(false);
        }
        else if(Garage.RCOwned == false)
        {
            RCCross.SetActive(true);
        }

        if (Garage.UFOOwned == true)
        {
            UFOCross.SetActive(false);
        }
        else if (Garage.UFOOwned == false)
        {
            UFOCross.SetActive(true);
        }

        if (Garage.TaxiOwned == true)
        {
            TaxiCross.SetActive(false);
        }
        else if (Garage.TaxiOwned == false)
        {
            TaxiCross.SetActive(true);
        }

        if (Garage.TruckOwned == true)
        {
            TruckCross.SetActive(false);
        }
        else if (Garage.TruckOwned == false)
        {
            TruckCross.SetActive(true);
        }

        if (Garage.TankOwned == true)
        {
            TankCross.SetActive(false);
        }
        else if (Garage.TankOwned == false)
        {
            TankCross.SetActive(true);
        }

        if (Garage.MonsterOwned == true)
        {
            MonsterCross.SetActive(false);
        }
        else if (Garage.MonsterOwned == false)
        {
            MonsterCross.SetActive(true);
        }

        if (Garage.DozerOwned == true)
        {
            DozerCross.SetActive(false);
        }
        else if (Garage.DozerOwned == false)
        {
            DozerCross.SetActive(true);
        }

        if (Garage.SkyCarOwned == true)
        {
            SkyCarCross.SetActive(false);
        }
        else if (Garage.SkyCarOwned == false)
        {
            SkyCarCross.SetActive(true);
        }
    }

    public void PickRC()
    {
        if (Garage.RCOwned == true)
        {
            PlayerRC.SetActive(true);
            AIRC.SetActive(false);
            SkyCarRC.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.RCOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickTaxi()
    {
        if (Garage.TaxiOwned == true)
        {
            PlayerTaxi.SetActive(true);
            AITaxi.SetActive(false);
            SkyCarTaxi.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.TaxiOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickUFO()
    {
        if (Garage.UFOOwned == true)
        {
            PlayerUFO.SetActive(true);
            AIUFO.SetActive(false);
            SkyCarUFO.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.UFOOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickTank()
    {
        if (Garage.TankOwned == true)
        {
            PlayerTank.SetActive(true);
            AITank.SetActive(false);
            SkyCarTank.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.TankOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickDozer()
    {
        if (Garage.DozerOwned == true)
        {
            PlayerDozer.SetActive(true);
            AIDozer.SetActive(false);
            SkyCarDozer.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.DozerOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickTruck()
    {
        if (Garage.TruckOwned == true)
        {
            PlayerTruck.SetActive(true);
            AITruck.SetActive(false);
            SkyCarTruck.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.TruckOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickMonster()
    {
        if (Garage.MonsterOwned == true)
        {
            PlayerMonster.SetActive(true);
            AIMonster.SetActive(false);
            SkyCarMonster.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.MonsterOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickSkyCar()
    {
        if (Garage.SkyCarOwned == true)
        {
            PlayerSkyCar.SetActive(true);
            PauseMenu.gameIsPaused = false;
            FrontCam.SetActive(true);
            SkyCam.SetActive(false);
            RacerChosen = true;
            ChooseRacerUI.SetActive(false);
            GameUI.SetActive(true);
        }
        else if (Garage.SkyCarOwned == false)
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void PickRandom()
    {
        do
        {
            RandomNum = UnityEngine.Random.Range(0, 7);

            if (RandomNum == 0)
            {
                if (Garage.RCOwned == true)
                {
                    PickRC();
                    validRacer = true;
                }
                else { }
            }
            else if (RandomNum == 1)
            {
                if (Garage.UFOOwned == true)
                {
                    PickUFO();
                    validRacer = true;
                }
                else { }
            }
            else if (RandomNum == 2)
            {
                if (Garage.TaxiOwned == true)
                {
                    PickTaxi();
                    validRacer = true;
                }
                else { }
            }
            else if (RandomNum == 3)
            {
                if (Garage.MonsterOwned == true)
                {
                    PickMonster();
                    validRacer = true;
                }
                else { }
            }
            else if (RandomNum == 4)
            {
                if (Garage.TankOwned == true)
                {
                    PickTank();
                    validRacer = true;
                }
                else { }
            }
            else if (RandomNum == 5)
            {
                if (Garage.TruckOwned == true)
                {
                    PickTruck();
                    validRacer = true;
                }
                else { }
            }
            else if (RandomNum == 6)
            {
                if (Garage.DozerOwned == true)
                {
                    PickDozer();
                    validRacer = true;
                }
                else { }
            }
            else if (RandomNum == 7)
            {
                if (Garage.SkyCarOwned == true)
                {
                    PickSkyCar();
                    validRacer = true;
                }
                else{ }
            }
        } while (validRacer == false);
    }
}
