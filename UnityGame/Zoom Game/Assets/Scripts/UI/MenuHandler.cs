using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
	[SerializeField] private GameObject controlsPanel;
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private GameObject pausePanel;
	[SerializeField] private GameObject settingsPanel;
	[SerializeField] private GameObject musicSource;

    [SerializeField] private bool pauseMenuIsShowing;
    Player player;
    private int counter;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {

        if (Input.GetKeyDown("escape") && mainMenu.activeSelf == false && settingsPanel.activeSelf == false)
        {
            pauseMenuIsShowing = !pauseMenuIsShowing;

            if (player.canInput == true)
                player.canInput = false;
            if (player.canInteract == true)
                player.canInteract = false;
		}
		pausePanel.SetActive(pauseMenuIsShowing);
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
    }
    public void SettingsMenu()
    {
        settingsPanel.SetActive(true);
        pauseMenuIsShowing = !pauseMenuIsShowing;
    }
    public void Credits()
    {
        counter++;

        if (counter % 2 == 1)
            creditsPanel.SetActive(true);
        else
            creditsPanel.SetActive(false);
    }
    public void ResumeGame()
    {
        pauseMenuIsShowing = !pauseMenuIsShowing;
    }
    public void BackToMenu()
    {
        if (settingsPanel.activeSelf == true)
            settingsPanel.SetActive(false);
        pauseMenuIsShowing = !pauseMenuIsShowing;
    }
}
