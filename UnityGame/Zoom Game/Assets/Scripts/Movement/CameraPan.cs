using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    ZoomHandler zoom;
    public Vector3 currentMouseScreenPosition;
    public Vector3 mouseScreenPositionLastFrame;
    public Vector3 mouseVector;

    void Start()
    {
        zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1)||Input.GetMouseButton(2))
        {
            if (zoom.hasControl)
            Panning();
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
