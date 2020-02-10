using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighlightRacer : MonoBehaviour
{
    public GameObject RC;
    public GameObject UFO;
    public GameObject Taxi;
    public GameObject Truck;
    public GameObject Tank;
    public GameObject Monster;
    public GameObject Dozer;
    public GameObject SkyCar;
    public GameObject Random;

    public GameObject RCBorder;
    public GameObject UFOBorder;
    public GameObject TaxiBorder;
    public GameObject TruckBorder;
    public GameObject TankBorder;
    public GameObject MonsterBorder;
    public GameObject DozerBorder;
    public GameObject SkyCarBorder;
    public GameObject RandomBorder;

    public GameObject RacerNameUI;

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
        Random.SetActive(false);

        RCBorder.SetActive(true);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(false);

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
        Random.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(true);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(false);

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
        Random.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(true);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(false);

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
        Random.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(true);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(false);

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
        Random.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(true);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(false);

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
        Random.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(true);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(false);

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
        Random.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(true);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(false);

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
        Random.SetActive(false);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(true);
        RandomBorder.SetActive(false);

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
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Sky Car";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(0, 255, 255, 255);
    }

    public void mouseOverRandom()
    {
        RC.SetActive(false);
        UFO.SetActive(false);
        Taxi.SetActive(false);
        Truck.SetActive(false);
        Tank.SetActive(false);
        Monster.SetActive(false);
        Dozer.SetActive(false);
        SkyCar.SetActive(false);
        Random.SetActive(true);

        RCBorder.SetActive(false);
        UFOBorder.SetActive(false);
        TaxiBorder.SetActive(false);
        TruckBorder.SetActive(false);
        TankBorder.SetActive(false);
        MonsterBorder.SetActive(false);
        DozerBorder.SetActive(false);
        SkyCarBorder.SetActive(false);
        RandomBorder.SetActive(true);

        TopSpeedSlider.value = 0;
        AccelerationSlider.value = 0;
        GripSlider.value = 0;
        HandlingSlider.value = 0;
        WeightSlider.value = 0;

        TopSpeedFill.color = new Color32(255, 255, 255, 255);
        AccelerationFill.color = new Color32(255, 255, 255, 255);
        GripFill.color = new Color32(255, 255, 255, 255);
        HandlingFill.color = new Color32(255, 255, 255, 255);
        WeightFill.color = new Color32(255, 255, 255, 255);

        FindObjectOfType<AudioManager>().Play("Click");
        RacerNameUI.GetComponent<TextMeshProUGUI>().text = "Random";
        RacerNameUI.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
    }
}
