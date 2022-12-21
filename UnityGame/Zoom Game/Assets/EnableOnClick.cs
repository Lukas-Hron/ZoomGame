using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnClick : MonoBehaviour
{
    bool hasClicked = false;
    public GameObject thingy;
    private void OnMouseDown()
    {
        if (!hasClicked)
        {
            thingy.SetActive(true);
            hasClicked = true;
        }
    }
}
