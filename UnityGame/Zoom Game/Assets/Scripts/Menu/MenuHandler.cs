using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
	[SerializeField] private GameObject creditsPanel;
	[SerializeField] private GameObject mainMenu;
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
	public void LoadMenu(string name)
	{
		SceneManager.LoadScene("Menu");
	}
	public void Credits()
	{
		counter++;

		if (counter % 2 == 1)
			creditsPanel.SetActive(true);
		else
			creditsPanel.SetActive(false);
		creditsPanel.Ac

	}
	public void BackToMenu()
	{
		creditsPanel.SetActive(false);
		mainMenu.SetActive(true);
	}
}
