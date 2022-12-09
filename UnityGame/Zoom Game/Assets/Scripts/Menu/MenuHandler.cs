using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
	[SerializeField] private GameObject creditsPanel;
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private GameObject pausePanel;
	[SerializeField] private bool pauseMenuIsShowing;
    private int counter;
    MenuCutscene cut;

	void Start()
	{
		cut = Object.FindObjectOfType<MenuCutscene>();
	}

    private void Update()
    {
		if (Input.GetKeyDown("escape") && mainMenu.activeSelf == false)
        {
			pauseMenuIsShowing = !pauseMenuIsShowing;
			pausePanel.SetActive(pauseMenuIsShowing);
		}
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
 //   public void PauseMenu(string name)
	//{
	//	if (Input.GetKeyDown("escape") /*&& mainMenu.activeSelf == false*/)
	//	{
	//		pauseMenuIsShowing = !pauseMenuIsShowing;
	//		pausePanel.SetActive(pauseMenuIsShowing);
	//		pausePanel.SetActive(true);
	//	}
	//}
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
		pausePanel.SetActive(false);
		mainMenu.SetActive(true);
	}
}
