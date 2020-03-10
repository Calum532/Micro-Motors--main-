using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PosUp : MonoBehaviour
{
    public GameObject positionDisplay;
    public GameObject DownPosTrigger;
    public GameObject UpPosTrigger;

    private void Start()
    {
        DownPosTrigger.SetActive(false);
        UpPosTrigger.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "CarPos")
        {
            if(PlayerPos.playerPosition > 1)
            {
                PlayerPos.playerPosition--;
                positionDisplay.GetComponent<TextMeshProUGUI>().text = PlayerPos.playerPosition.ToString();

                if (PlayerPos.playerPosition == 8 || PlayerPos.playerPosition == 7 || PlayerPos.playerPosition == 6 || PlayerPos.playerPosition == 5 || PlayerPos.playerPosition == 4)
                {
                    positionDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
                }
                else if (PlayerPos.playerPosition == 3)
                {
                    positionDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(176, 141, 87, 255);
                }
                else if (PlayerPos.playerPosition == 2)
                {
                    positionDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(170, 169, 173, 255);
                }
                else if (PlayerPos.playerPosition == 1)
                {
                    positionDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(211, 175, 55, 255);
                }

                DownPosTrigger.SetActive(true);
                UpPosTrigger.SetActive(false);
            }
        }
    }
}
