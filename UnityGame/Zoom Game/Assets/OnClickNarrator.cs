using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickNarrator : MonoBehaviour
{
    bool hasClicked = false;
    [SerializeField] string keyword;

    private void OnMouseDown()
    {
        if (!hasClicked)
        {
            NarratorHandler.Instance.PlayFromKeyWord(keyword);
            hasClicked = true;
        }
    }
}
