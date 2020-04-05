using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public TextMeshProUGUI progressText;
    private int RandomNum;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
    }

    public void LoadLevel_RandomStandardTrack()
    {
        RandomNum = UnityEngine.Random.Range(0, 3);

        if (RandomNum == 0)
        {
            LoadLevel(3);
        }
        else if (RandomNum == 1)
        {
            LoadLevel(4);
        }
        else if (RandomNum == 2)
        {
            LoadLevel(5);
        }
        else if (RandomNum == 3)
        {
            LoadLevel(6);
        }
    }

    public void LoadLevel_RandomTimeTrial()
    {
        RandomNum = UnityEngine.Random.Range(0, 3);

        if (RandomNum == 0)
        {
            LoadLevel(7);
        }
        else if (RandomNum == 1)
        {
            LoadLevel(8);
        }
        else if (RandomNum == 2)
        {
            LoadLevel(9);
        }
        else if (RandomNum == 3)
        {
            LoadLevel(10);
        }
    }

    public void LoadLevel_RandomAITrack()
    {
        RandomNum = UnityEngine.Random.Range(0, 3);

        if (RandomNum == 0)
        {
            LoadLevel(11);
        }
        else if (RandomNum == 1)
        {
            LoadLevel(12);
        }
        else if (RandomNum == 2)
        {
            LoadLevel(13);
        }
        else if (RandomNum == 3)
        {
            LoadLevel(14);
        }
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = "LOADING..." + (progress * 100f).ToString("0") + "%";
            yield return null;
        }
    }
}
