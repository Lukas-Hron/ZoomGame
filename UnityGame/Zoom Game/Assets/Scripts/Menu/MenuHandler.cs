using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
	[SerializeField] private GameObject creditsPanel;
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private GameObject pausePanel;
	[SerializeField] private GameObject settingsPanel;
	[SerializeField] private bool pauseMenuIsShowing;
    private int counter;
    MenuCutscene cut;

	void Start()
	{
		cut = Object.FindObjectOfType<MenuCutscene>();
	}

    private void Update()
    {
		if (Input.GetKeyDown("escape") && mainMenu.activeSelf == false && settingsPanel.activeSelf == false)
        {
			pauseMenuIsShowing = !pauseMenuIsShowing;
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
	public void StartGame(string name)
    {
        //startgame function
        cut.startCutscene = true;
		mainMenu.SetActive(false);
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
