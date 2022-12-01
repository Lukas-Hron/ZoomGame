using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
	[SerializeField] private GameObject creditsPanel;
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private GameObject settingsPanel;
    private int counter;
    MenuCutscene cut;

	void Start()
	{
		cut = Object.FindObjectOfType<MenuCutscene>();
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
    public void SettingsMenu(string name)
	{
		settingsPanel.SetActive(true);
		mainMenu.SetActive(false);
	}
	public void Credits()
	{
		counter++;

		if (counter % 2 == 1)
			creditsPanel.SetActive(true);
		else
			creditsPanel.SetActive(false);

	}
	public void BackToMenu()
	{
		settingsPanel.SetActive(false);
		mainMenu.SetActive(true);
	}
}
