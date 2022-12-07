using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canInput;
    public bool canZoom;
    public bool canPan;
    public bool canInteract;
    public bool startDragInteract;
    public bool isDragInteract;
    public bool isZooming;
    public bool isPanning;
    public bool inCutscene;

    public void toggleCutscene()
    {
        inCutscene = !inCutscene;
    }
}
