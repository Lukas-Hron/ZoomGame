using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHandler : MonoBehaviour
{
    [SerializeField] private GameObject zoomTutorial;
    [SerializeField] private GameObject panTutorial;
    [SerializeField] private GameObject interactTutorial;
    Player player;
    bool checkingPan;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        if (checkingPan)
        {
            if (player.isPanning)
            {
                ExitPan();
                Invoke(methodName: "DisplayInteract", 2);
                checkingPan = false;
            }
        }
    }

    public void DisplayZoom()
    {
        zoomTutorial.SetActive(true);
    }
    public void DisplayPan()
    {
        panTutorial.SetActive(true);
        checkingPan = true;
    }
    public void DisplayInteract()
    {
        interactTutorial.SetActive(true);
        Invoke(methodName: "ExitInteract", 5);
    }

    public void ExitInteract()
    {
        interactTutorial.GetComponent<Animator>().SetTrigger("exit");
        Invoke(methodName:"DisableAllTutorial", 3);
    }
    public void ExitPan()
    {
        panTutorial.GetComponent<Animator>().SetTrigger("exit");
    }
    public void ExitZoom()
    {
        zoomTutorial.GetComponent<Animator>().SetTrigger("exit");
    }
    public void DisableAllTutorials()
    {
        zoomTutorial.SetActive(false);
        panTutorial.SetActive(false);
        interactTutorial.SetActive(false);
    }
}
