using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject pauseMenuUI;
    public GameObject controlsUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void DisplayControls()
    {
        pauseMenuUI.SetActive(false);
        controlsUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        gameIsPaused = false;
        pauseMenuUI.SetActive(false);
    }

    public void Back()
    {
        pauseMenuUI.SetActive(true);
        controlsUI.SetActive(false);
    }

    public void LoadMainMenu()
    {
        Debug.Log("Loading Main Menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
