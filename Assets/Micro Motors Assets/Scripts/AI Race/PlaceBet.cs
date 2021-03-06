﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBet : MonoBehaviour
{
    public static float betAmount = 0;
    public GameObject BetUI;
    public GameObject ChooseRacerUI;

    public void Start()
    {
        PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
    }

    public void Bet_250()
    {
        if (GlobalCash.TotalCredits >= 250)
        {
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - 250;
            PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
            betAmount = 250;
            BetUI.SetActive(false);
            ChooseRacerUI.SetActive(true);
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void Bet_500()
    {
        if (GlobalCash.TotalCredits >= 500)
        {
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - 500;
            PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
            betAmount = 500;
            BetUI.SetActive(false);
            ChooseRacerUI.SetActive(true);
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void Bet_750()
    {
        if (GlobalCash.TotalCredits >= 750)
        {
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - 750;
            PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
            betAmount = 750;
            BetUI.SetActive(false);
            ChooseRacerUI.SetActive(true);
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }

    public void Bet_1000()
    {
        if (GlobalCash.TotalCredits >= 1000)
        {
            GlobalCash.TotalCredits = GlobalCash.TotalCredits - 1000;
            PlayerPrefs.SetFloat("SavedCash", GlobalCash.TotalCredits);
            betAmount = 1000;
            BetUI.SetActive(false);
            ChooseRacerUI.SetActive(true);
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Nope");
        }
    }
}
