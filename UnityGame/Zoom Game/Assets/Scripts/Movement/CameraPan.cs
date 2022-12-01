using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    ZoomHandler zoom;
    public Vector3 currentMouseScreenPosition;
    public Vector3 mouseScreenPositionLastFrame;
    public Vector3 mouseVector;
    private MouseCursor mouseCursor;
    private bool beginPanning = false;
    private bool stopPanning = true;

    void Start()
    {
        mouseCursor = new MouseCursor();
        var texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorDefault");
        mouseCursor.changeCursorTexture(texturen);
        mouseCursor.updateCursor();
        zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    void Update()
    {
        if (zoom.hasControl)
        {
            if (stopPanning && (!(Input.GetMouseButton(1) || Input.GetMouseButton(2))))
            {
                var texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorDefault");
                mouseCursor.changeCursorTexture(texturen);
                mouseCursor.updateCursor();
                stopPanning = false;
            }

            else if (Input.GetMouseButton(1) || Input.GetMouseButton(2))
            {
                if (!beginPanning)
                {
                    var texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorPanning");
                    beginPanning = true;
                    stopPanning = false;
                    mouseCursor.changeCursorTexture(texturen);
                    mouseCursor.updateCursor();
                }
                Panning();
            }
            else
            {
                stopPanning = true;
                beginPanning = false;
            }


        }


    }

    public void Panning()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            mouseScreenPositionLastFrame = Input.mousePosition;
        }

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
