using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickNarrator : MonoBehaviour
{
    bool hasClicked = false;
    Player Player;
    [SerializeField] string keyword;

    private void Start()
    {
        Player = FindObjectOfType<Player>();
    }
    private void OnMouseDown()
    {
        if (!hasClicked && Player.canInteract)
        {
            NarratorHandler.Instance.PlayFromKeyWord(keyword);
            hasClicked = true;
        }
    }
}
