using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        bool isPaused = pausePanel.activeSelf;
        pausePanel.SetActive(!isPaused);
        Time.timeScale = isPaused ? 1 : 0;
    }

    public void OnContinueButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnExitButton()
    {
        Time.timeScale = 1; // importante: resetear antes de cambiar de escena
        SceneManager.LoadScene("MainMenu");
    }
}