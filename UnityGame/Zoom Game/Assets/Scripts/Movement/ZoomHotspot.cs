using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZoomHotspot : MonoBehaviour
{
    public bool CanZoomInMiddle;
    [SerializeField] private float maxZoomClamp;
    public Transform radiusPoint;
    float radius;
    ZoomHandler zoom;
    bool mouseWithin;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    private void FixedUpdate()
    {
        radius = Vector2.Distance(radiusPoint.position, gameObject.transform.position);
        if (Vector2.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)) < radius)
        {
            mouseWithin = true;
            if (CanZoomInMiddle)
            {
                player.isLockedZoom = true;
                zoom.lockedZoomOrigin = gameObject.transform;
            }



            if (zoom.hotSpotMax < maxZoomClamp)
            zoom.hotSpotMax = maxZoomClamp;
        }
        else if (mouseWithin)
        {
            mouseWithin = false;
            zoom.hotSpotMax = 0;
            if (CanZoomInMiddle)
            player.isLockedZoom = false;
        }
    }
    private void OnDestroy()
    {
        player.isLockedZoom = false;
    }
    private void OnDisable()
    {
        player.isLockedZoom = false;
    }
}
