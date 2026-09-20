using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Button btnPlay;
    

    [SerializeField] private GameObject panelSettings;
    [SerializeField] private Button btnSettingsPanel;
    [SerializeField] private Button btnback;

    [SerializeField] private GameObject panelCredits;
    [SerializeField] private Button btnCreditsPanel;
    [SerializeField] private Button btnBackCredits;


    private GameObject previousPanel;
   

    private void Start()
    {
        previousPanel = mainMenu;

        panelSettings.SetActive(false);
        panelCredits.SetActive(false);

        btnPlay.onClick.AddListener(PlayGame);

        btnSettingsPanel.onClick.AddListener(() => OpenSettings(mainMenu));
        btnback.onClick.AddListener(CloseSettings);

        btnCreditsPanel.onClick.AddListener(() => OpenCredits(mainMenu));
        btnBackCredits.onClick.AddListener(CloseCredits);

    }

    private void Update()
    {
       
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }


    private void OpenSettings(GameObject caller)
    {
        previousPanel = caller;
        caller.SetActive(false);
        panelSettings.SetActive(true);
    }

    private void CloseSettings()
    {
        panelSettings.SetActive(false);
        previousPanel.SetActive(true);
    }

    private void OpenCredits(GameObject caller)
    {
        previousPanel = caller;
        caller.SetActive(false);
        panelCredits.SetActive(true);
    }

    private void CloseCredits()
    {
        panelCredits.SetActive(false);
        previousPanel.SetActive(true);
    }

}
