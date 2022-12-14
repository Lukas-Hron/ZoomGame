using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Curser curser;

    public bool isLockedZoom;
    public bool canInput;
    public bool canZoom;
    public bool canPan;
    public bool canInteract;
    public bool startDragInteract;
    public bool isDragInteract;
    public bool isZooming;
    public bool isPanning;
    public bool canClick;
    public bool inCutscene;
    public bool isItemInteract;
    public bool hasRightItem;

    public void toggleCutscene()
    {
        inCutscene = !inCutscene;
    }

    public void SetCurserSprite(Sprite item)
    {
        curser.currentItem = item;
    }
}
