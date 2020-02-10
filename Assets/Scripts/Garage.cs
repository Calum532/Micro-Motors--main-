using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Garage : MonoBehaviour
{
    public static bool RCOwned = false;
    public static bool UFOOwned = false;
    public static bool TaxiOwned = false;
    public static bool TruckOwned = true;
    public static bool TankOwned = false;
    public static bool MonsterOwned = false;
    public static bool DozerOwned = false;
    public static bool SkyCarOwned = false;

    public int RCCost;
    public int UFOCost;
    public int TaxiCost;
    public int TruckCost;
    public int TankCost;
    public int MonsterCost;
    public int DozerCost;
    public int SkyCarCost;

    public GameObject RC;
    public GameObject UFO;
    public GameObject Taxi;
    public GameObject Truck;
    public GameObject Tank;
    public GameObject Monster;
    public GameObject Dozer;
    public GameObject SkyCar;

    public GameObject RCBorder;
    public GameObject UFOBorder;
    public GameObject TaxiBorder;
    public GameObject TruckBorder;
    public GameObject TankBorder;
    public GameObject MonsterBorder;
    public GameObject DozerBorder;
    public GameObject SkyCarBorder;

    public GameObject RCTick;
    public GameObject UFOTick;
    public GameObject TaxiTick;
    public GameObject TruckTick;
    public GameObject TankTick;
    public GameObject MonsterTick;
    public GameObject DozerTick;
    public GameObject SkyCarTick;

    public GameObject RCCross;
    public GameObject UFOCross;
    public GameObject TaxiCross;
    public GameObject TruckCross;
    public GameObject TankCross;
    public GameObject MonsterCross;
    public GameObject DozerCross;
    public GameObject SkyCarCross;

    public GameObject RacerNameUI;
    public GameObject RacerPrice;

    public Slider TopSpeedSlider;
    public Slider AccelerationSlider;
    public Slider GripSlider;
    public Slider HandlingSlider;
    public Slider WeightSlider;

    public Image TopSpeedFill;
    public Image AccelerationFill;
    public Image GripFill;
    public Image HandlingFill;
    public Image WeightFill;

    public void mouseOverRC()
    {
        RC.SetActive(true);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);

        RCBorder.SetActive(true);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 2;
        AccelerationSlider.value = 10;
        GripSlider.value = 6;
        HandlingSlider.value = 10;
        WeightSlider.value = 2;

        TopSpeedFill.color = new Color32(0, 0, 255, 255);
        AccelerationFill.color = new Color32(0, 0, 255, 255);
        GripFill.color = new Color32(0, 0, 255, 255);
        HandlingFill.color = new Color32(0, 0, 255, 255);
        WeightFill.color = new Color32(0, 0, 255, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if(RCOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + RCCost;
        }
        else if(RCOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "R.C.";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 0, 255, 255);
    }

    public void mouseOverUFO()
    {
        RC.SetActive(false);
        UFO.SetActive(true);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(true);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 10;
        AccelerationSlider.value = 10;
        GripSlider.value = 2;
        HandlingSlider.value = 4;
        WeightSlider.value = 4;

        TopSpeedFill.color = new Color32(169, 169, 169, 255);
        AccelerationFill.color = new Color32(169, 169, 169, 255);
        GripFill.color = new Color32(169, 169, 169, 255);
        HandlingFill.color = new Color32(169, 169, 169, 255);
        WeightFill.color = new Color32(169, 169, 169, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if (UFOOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + UFOCost;
        }
        else if (UFOOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "UFO";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(169, 169, 169, 255);
    }

    public void mouseOverTaxi()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(true);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(true);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 6;
        AccelerationSlider.value = 8;
        GripSlider.value = 6;
        HandlingSlider.value = 6;
        WeightSlider.value = 4;

        TopSpeedFill.color = new Color32(255, 255, 0, 255);
        AccelerationFill.color = new Color32(255, 255, 0, 255);
        GripFill.color = new Color32(255, 255, 0, 255);
        HandlingFill.color = new Color32(255, 255, 0, 255);
        WeightFill.color = new Color32(255, 255, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if (TaxiOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + TaxiCost;
        }
        else if (TaxiOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Taxi";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 0, 255);
    }

    public void mouseOverTruck()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(true);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(true);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 6;
        AccelerationSlider.value = 6;
        GripSlider.value = 6;
        HandlingSlider.value = 4;
        WeightSlider.value = 8;

        TopSpeedFill.color = new Color32(255, 0, 0, 255);
        AccelerationFill.color = new Color32(255, 0, 0, 255);
        GripFill.color = new Color32(255, 0, 0, 255);
        HandlingFill.color = new Color32(255, 0, 0, 255);
        WeightFill.color = new Color32(255, 0, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if (TruckOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + TruckCost;
        }
        else if (TruckOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Truck";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 0, 0, 255);
    }

    public void mouseOverTank()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(true);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(true);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 4;
        AccelerationSlider.value = 2;
        GripSlider.value = 8;
        HandlingSlider.value = 6;
        WeightSlider.value = 10;

        TopSpeedFill.color = new Color32(0, 150, 0, 255);
        AccelerationFill.color = new Color32(0, 150, 0, 255);
        GripFill.color = new Color32(0, 150, 0, 255);
        HandlingFill.color = new Color32(0, 150, 0, 255);
        WeightFill.color = new Color32(0, 150, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if (TankOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + TankCost;
        }
        else if (TankOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Tank";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 150, 0, 255);
    }

    public void mouseOverMonster()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(true);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(true);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 6;
        AccelerationSlider.value = 8;
        GripSlider.value = 4;
        HandlingSlider.value = 4;
        WeightSlider.value = 8;

        TopSpeedFill.color = new Color32(125, 0, 255, 255);
        AccelerationFill.color = new Color32(125, 0, 255, 255);
        GripFill.color = new Color32(125, 0, 255, 255);
        HandlingFill.color = new Color32(125, 0, 255, 255);
        WeightFill.color = new Color32(125, 0, 255, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if (MonsterOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + MonsterCost;
        }
        else if (MonsterOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Monster";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(125, 0, 255, 255);
    }

    public void mouseOverDozer()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(true);
        SkyCar.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(true);
        SkyCarBorder.SetActive(false);

        TopSpeedSlider.value = 8;
        AccelerationSlider.value = 2;
        GripSlider.value = 8;
        HandlingSlider.value = 2;
        WeightSlider.value = 10;

        TopSpeedFill.color = new Color32(255, 125, 0, 255);
        AccelerationFill.color = new Color32(255, 125, 0, 255);
        GripFill.color = new Color32(255, 125, 0, 255);
        HandlingFill.color = new Color32(255, 125, 0, 255);
        WeightFill.color = new Color32(255, 125, 0, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if (DozerOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + DozerCost;
        }
        else if (DozerOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Dozer";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 125, 0, 255);
    }

    public void mouseOverSkyCar()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(true);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(true);

        TopSpeedSlider.value = 6;
        AccelerationSlider.value = 6;
        GripSlider.value = 6;
        HandlingSlider.value = 6;
        WeightSlider.value = 6;

        TopSpeedFill.color = new Color32(0, 255, 255, 255);
        AccelerationFill.color = new Color32(0, 255, 255, 255);
        GripFill.color = new Color32(0, 255, 255, 255);
        HandlingFill.color = new Color32(0, 255, 255, 255);
        WeightFill.color = new Color32(0, 255, 255, 255);

        FindObjectOfType<AudioManager>().Play("Click");

        if (SkyCarOwned == false)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Price: $" + SkyCarCost;
        }
        else if (SkyCarOwned == true)
        {
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }

        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Sky Car";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 255, 255, 255);
    }

    public void ClickPurchase()
    {
        if(RC.activeInHierarchy && GlobalCash.TotalCredits >= RCCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - RCCost;
            RCOwned = true;
            RCTick.SetActive(true);
            RCCross.SetActive(false);
            RCCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        } else if(UFO.activeInHierarchy && GlobalCash.TotalCredits >= UFOCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - UFOCost;
            UFOOwned = true;
            UFOTick.SetActive(true);
            UFOCross.SetActive(false);
            UFOCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        } else if(Taxi.activeInHierarchy && GlobalCash.TotalCredits >= TaxiCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - TaxiCost;
            TaxiOwned = true;
            TaxiTick.SetActive(true);
            TaxiCross.SetActive(false);
            TaxiCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        } else if(Truck.activeInHierarchy && GlobalCash.TotalCredits >= TruckCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - TruckCost;
            TruckOwned = true;
            TruckTick.SetActive(true);
            TruckCross.SetActive(false);
            TruckCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        } else if(Tank.activeInHierarchy && GlobalCash.TotalCredits >= TankCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - TankCost;
            TankOwned = true;
            TankTick.SetActive(true);
            TankCross.SetActive(false);
            TankCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        } else if(Monster.activeInHierarchy && GlobalCash.TotalCredits >= MonsterCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - MonsterCost;
            MonsterOwned = true;
            MonsterTick.SetActive(true);
            MonsterCross.SetActive(false);
            MonsterCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        } else if (Dozer.activeInHierarchy && GlobalCash.TotalCredits >= DozerCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - DozerCost;
            DozerOwned = true;
            DozerTick.SetActive(true);
            DozerCross.SetActive(false);
            DozerCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        } else if (SkyCar.activeInHierarchy && GlobalCash.TotalCredits >= SkyCarCost)
        {
            FindObjectOfType<AudioManager>().Play("Cha-Ching");
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - SkyCarCost;
            SkyCarOwned = true;
            SkyCarTick.SetActive(true);
            SkyCarCross.SetActive(false);
            SkyCarCost = 0;
            RacerPrice.GetComponent<TextMeshProUGUI>().text = "Owned";
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }
}
