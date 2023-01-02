using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
	[SerializeField] private GameObject tutorial;
	[SerializeField] private GameObject controlsPanel;
	[SerializeField] private GameObject creditsPanel;
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private GameObject pausePanel;
	[SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject exitGamePanel;
	[SerializeField] private GameObject musicSource;
    [SerializeField] private bool pauseMenuIsShowing;
    Player player;
    bool checkmenu;
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
		if (Input.GetKeyDown("escape"))
		{
            if (mainMenu.activeSelf == false && settingsPanel.activeSelf == false && player.canOnlyZoomIn == false && controlsPanel.activeSelf == false && player.inCutscene == false && creditsPanel.activeSelf == false && exitGamePanel.activeSelf == false)
            {
                pauseMenuIsShowing = !pauseMenuIsShowing;
                if (pauseMenuIsShowing)
                    player.canInput = false;
                    player.canInteract = false;
                    tutorial.SetActive(false);
                checkmenu = true;
            }
            else if (controlsPanel.activeSelf == true || settingsPanel.activeSelf == true || creditsPanel.activeSelf == true || exitGamePanel.activeSelf == true)
            {
                if (settingsPanel.activeSelf == true)
                    settingsPanel.SetActive(false);
                if (controlsPanel.activeSelf == true)
                    controlsPanel.SetActive(false);
                if (creditsPanel.activeSelf == true)
                    creditsPanel.SetActive(false);
                if (exitGamePanel.activeSelf == true)
                    exitGamePanel.SetActive(false);
                if (pauseMenuIsShowing == false)
                    pauseMenuIsShowing = !pauseMenuIsShowing;
            }
		}

        if (pauseMenuIsShowing == false && settingsPanel.activeSelf == false && controlsPanel.activeSelf == false && checkmenu)
        {
            settingsPanel.SetActive(false);
            player.canInteract = true;
            player.canInput = true;
            checkmenu = false;  
        }
        pausePanel.SetActive(pauseMenuIsShowing);
	}

    public void ExitGame()
    {
        exitGamePanel.SetActive(true);
        pauseMenuIsShowing = !pauseMenuIsShowing;
    }
    public void Quit()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
	}
	public void StartGame()
    {
        //startgame function
        mainMenu.SetActive(false);
        player.canInput = true;
        player.canOnlyZoomIn = true;
        musicSource.SetActive(true);
        GetComponent<TutorialHandler>().DisplayZoom();

    }
    public void SettingsMenu()
    {
        settingsPanel.SetActive(true);
        pauseMenuIsShowing = !pauseMenuIsShowing;
    }
    public void ControlsMenu()
    {
        controlsPanel.SetActive(true);
        pauseMenuIsShowing = !pauseMenuIsShowing;
    }
    public void CreditsMenu()
    {
        creditsPanel.SetActive(true);
        pauseMenuIsShowing = !pauseMenuIsShowing;

    }
    public void ResumeGame()
    {
        pauseMenuIsShowing = !pauseMenuIsShowing;
        if (player.canInput == false)
        {
            player.canInput = true;
        }
        if (player.canInteract == false)
        {
            player.canInteract = true;
        }
    }
    public void BackToMenu()
    {
        if (settingsPanel.activeSelf == true)
            settingsPanel.SetActive(false);
        if (controlsPanel.activeSelf == true)
            controlsPanel.SetActive(false);
        if (creditsPanel.activeSelf == true)
            creditsPanel.SetActive(false);
        if (exitGamePanel.activeSelf == true)
            exitGamePanel.SetActive(false);
        if (pauseMenuIsShowing == false)
            pauseMenuIsShowing = !pauseMenuIsShowing;
    }
}
