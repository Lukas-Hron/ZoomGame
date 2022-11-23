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
		SceneManager.LoadScene("Game");
	}
	public void SettingsMenu(string name)
	{
		settingsPanel.SetActive(true);
		mainMenu.SetActive(true);
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
		creditsPanel.SetActive(false);
		mainMenu.SetActive(true);
	}
}
