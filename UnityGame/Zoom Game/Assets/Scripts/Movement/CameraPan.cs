using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public Vector3 currentMouseScreenPosition;
    public Vector3 mouseScreenPositionLastFrame;
    public Vector3 mouseVector;
    private mouseCursor musPekaren;
    private bool beginPanning = false;
    private bool stopPanning = true;

    private void Start()
    {
        musPekaren = new mouseCursor();
        var texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorDefault");
        musPekaren.changeCursorTexture(texturen);
        musPekaren.updateCursor();
    }

    void Update() {
        if (stopPanning && (!(Input.GetMouseButton(1) || Input.GetMouseButton(2)))) {
            var texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorDefault");
            musPekaren.changeCursorTexture(texturen);
            musPekaren.updateCursor();
            stopPanning = false;
        }

        else if (Input.GetMouseButton(1) || Input.GetMouseButton(2)) {
            if (!beginPanning)
            {
                var texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorPanning");
                beginPanning = true;
                stopPanning = false;
                musPekaren.changeCursorTexture(texturen);
                musPekaren.updateCursor();
            }
            Panning();
        }
        else
        {
            stopPanning = true;
            beginPanning = false;
        }


    }

    public void Panning()
    {
        mouseScreenPositionLastFrame = Input.mousePosition;
        currentMouseScreenPosition = Input.mousePosition;

            mouseVector = mouseScreenPositionLastFrame - currentMouseScreenPosition;
            mouseVector.x /= Screen.width;
            mouseVector.x *= Camera.main.orthographicSize * 2 * Camera.main.aspect;

            mouseVector.y /= Screen.height;
            mouseVector.y *= Camera.main.orthographicSize * 2;
            transform.position += mouseVector;

            mouseScreenPositionLastFrame = Input.mousePosition;
    }
}
