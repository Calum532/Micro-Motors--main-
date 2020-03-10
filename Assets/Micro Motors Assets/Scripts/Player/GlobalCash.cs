using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalCash : MonoBehaviour
{
    public float CreditsValue;
    public static float TotalCredits;
    public GameObject CreditsDisplay;
    
    void Start()
    {
        TotalCredits = PlayerPrefs.GetInt("SavedCash");
    }

    void Update()
    {
        CreditsValue = TotalCredits;
        CreditsDisplay.GetComponent<TextMeshProUGUI>().text = "Credits: $" + CreditsValue;
    }
}
