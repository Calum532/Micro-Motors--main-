using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPos : MonoBehaviour
{
    public static int playerPosition;
    public GameObject PositionDisplayChild;

    void Start()
    {
        playerPosition = 8;
    }

    void Update()
    {
        if(playerPosition == 8 || playerPosition == 7 || playerPosition == 6 || playerPosition == 5 || playerPosition == 4)
        {
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().text = "th";
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
        }
        else if (playerPosition == 3)
        {
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().text = "rd";
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().color = new Color32(176, 141, 87, 255);
        }
        else if (playerPosition == 2)
        {
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().text = "nd";
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().color = new Color32(170, 169, 173, 255);
        }
        else if (playerPosition == 1)
        {
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().text = "st";
            PositionDisplayChild.GetComponent<TextMeshProUGUI>().color = new Color32(211, 175, 55, 255);
        }
    }
}
