using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public Player player;
    public Vector3 currentMouseScreenPosition;
    public Vector3 mouseScreenPositionLastFrame;
    // Vector to store the difference between the mouse positions in the current and last frames
    public Vector3 mouseVector;
    // Vector to store the target position of the camera
    Vector3 targetPos;

    // Distance from the edge of the screen where panning slows down
    [SerializeField] private float conSlowZone;
    // Speed at which the camera moves towards its target position
    [SerializeField] private float smoothPan;

    Transform conTopRight, conBottomLeft;
    public Transform layer;
    float cameraSize;
    float cameraAspect;
    // Flag to track whether the camera is currently panning
    bool isPanning;

    public void Start()
    {
        // Get the size and aspect ratio of the camera
        cameraSize = Camera.main.orthographicSize;
        cameraAspect = Camera.main.aspect;
    }

    void Update()
    {
        // If the right or middle mouse button is being held down, start panning the camera
        if ((Input.GetMouseButton(1) || Input.GetMouseButton(2)) && player.canInput && player.canPan)
        {
            Panning();
            isPanning = true;
            player.isPanning = true;
        }


        if (player.isZooming)
        {
            MoveDirectlyToClampedPosition();
        }

        // If the right or middle mouse button is released, move the camera to its clamped position
        if ((Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2)) && player.canInput && player.canPan)
        {
            isPanning = true;
            player.isPanning = false;
            MoveDirectlyToClampedPosition();

        }

        // If the camera is currently panning, move it towards its target position
        if (isPanning)
            MoveTowardsTarget();
    }

    // Method to smoothly move the camera towards its target position
    void MoveTowardsTarget()
    {
        // Calculate the new position of the camera by moving it a certain percentage
        // of the distance to its target position each frame
        Vector3 pos = Vector3.Lerp(transform.position, targetPos, smoothPan);
        // Set the z-coordinate of the camera to -10 to ensure it is rendered behind other objects
        pos.z = -10;
        // Update the position of the camera
        transform.position = pos;

        // If the distance between the camera and its target position is less than a certain threshold,
        // stop panning the camera
        if (Vector3.Distance(transform.position, targetPos) < 0.01)
        {
            isPanning = false;

        }
    }

    // Method to handle panning the camera
    public void Panning()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            mouseScreenPositionLastFrame = Input.mousePosition;
        }

        // Update the current position of the mouse
        currentMouseScreenPosition = Input.mousePosition;

        // Calculate the difference between the current and last positions of the mouse
        mouseVector = mouseScreenPositionLastFrame - currentMouseScreenPosition;

        // Scale the mouse vector so that it corresponds to the movement of the camera
        mouseVector.x /= Screen.width;
        mouseVector.x *= cameraSize * 2 * cameraAspect;

        mouseVector.y /= Screen.height;
        mouseVector.y *= cameraSize * 2;

        // Update the target position of the camera based on the mouse movement
        targetPos = ClampCameraPosition(conTopRight.position, conBottomLeft.position, targetPos, mouseVector);

        // Update the last position of the mouse for the next frame
        mouseScreenPositionLastFrame = Input.mousePosition;
    }

    // Method to clamp the camera position so that it doesn't move outside of the specified bounds
    Vector3 ClampCameraPosition(Vector2 topRightPos, Vector2 bottomLeftPos, Vector2 cameraPos, Vector2 mouseVec)
    {
        // Calculate the minimum and maximum x and y values for the camera.
        // These are the coordinates of the top-right and bottom-left
        // corners of the camera's viewport.
        float minX = bottomLeftPos.x + cameraSize * cameraAspect;
        float maxX = topRightPos.x - cameraSize * cameraAspect;
        float minY = bottomLeftPos.y + cameraSize;
        float maxY = topRightPos.y - cameraSize;

        // Calculate the minimum distance of the camera from the edge of the screen
        float minDis = Mathf.Min
        (
            cameraPos.x - minX,   // Distance to left edge
            maxX - cameraPos.x,   // Distance to right edge
            cameraPos.y - minY,   // Distance to bottom edge
            maxY - cameraPos.y    // Distance to top edge
        );

        // Scale the mouse vector so that it slows down when the camera is close to the edge of the screen
        mouseVec *= Mathf.InverseLerp(0, conSlowZone, minDis);

        // Update the camera position based on the mouse vector
        cameraPos += mouseVec;

        // Use the Mathf.Clamp() method to ensure that the camera's
        // position stays within the calculated bounds.
        float clampedX = Mathf.Clamp(cameraPos.x, minX, maxX);
        float clampedY = Mathf.Clamp(cameraPos.y, minY, maxY);

        // Return the clamped position of the camera.
        return new Vector3(clampedX, clampedY, -10);
    }
    public void UpdatePanConstraints()
    {
        if (player.isPanConstrained)
        {
        // Get the transforms for the top-right and bottom-left constraints
        conTopRight = layer.GetComponent<Layer>().topRight;
        conBottomLeft = layer.GetComponent<Layer>().bottomLeft;

        }
    }

    public void MoveDirectlyToClampedPosition()
    {
        if (player.isPanConstrained)
        {
            targetPos = ClampCameraPosition
        (
            new Vector2(conTopRight.position.x - conSlowZone, conTopRight.position.y - conSlowZone),
            new Vector2(conBottomLeft.position.x + conSlowZone, conBottomLeft.position.y + conSlowZone),
            targetPos,
            Vector2.zero
        );
            isPanning = true;
        }
    }
}