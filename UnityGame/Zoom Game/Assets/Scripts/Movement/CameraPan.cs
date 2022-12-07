using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    ZoomHandler zoom;
    public Vector3 currentMouseScreenPosition;
    public Vector3 mouseScreenPositionLastFrame;
    public Vector3 mouseVector;
    private bool beginPanning = false;
    private bool stopPanning = true;

    public CameraPan()
    {
        currentMouseScreenPosition = Vector3.zero;
        mouseScreenPositionLastFrame = Vector3.zero;
        mouseVector = Vector3.zero;
        beginPanning = false;
        stopPanning = true;
    }
    public void initiate()
    {
        zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    public Player ZoomUpdate(Player player)
    {
        Player _player = player;
        if (zoom.hasControl)
        {
            if (stopPanning && (!(Input.GetMouseButton(1) || Input.GetMouseButton(2))))
            {
                player.getMouseCursor().changeCursor(0);
                stopPanning = false;
            }

            else if (Input.GetMouseButton(1) || Input.GetMouseButton(2))
            {
                if (!beginPanning)
                {
                    beginPanning = true;
                    stopPanning = false;
                    _player.setNewState(StateMachine.PlayerState.panning);
                }
                Panning();
            }
            else
            {
                stopPanning = true;
                beginPanning = false;
                _player.setNewState(StateMachine.PlayerState.idle);
            }

        }

        return _player;
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
