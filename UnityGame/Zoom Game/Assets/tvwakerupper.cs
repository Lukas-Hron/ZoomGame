using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvwakerupper : MonoBehaviour
{
    bool hasPlayedOnce;
    public TVPuzzle tv;
    private void OnEnable()
    {
        if (!hasPlayedOnce)
            tv.TurnOnTV();
        hasPlayedOnce = true;
    }
}
