using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZoomHotspot : MonoBehaviour
{
    [SerializeField] private float maxZoomClamp;
    public Transform radiusPoint;
    float radius;
    ZoomHandler zoom;
    bool mouseWithin;


    // Start is called before the first frame update
    void Start()
    {
        zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    private void FixedUpdate()
    {
        radius = Vector2.Distance(radiusPoint.position, gameObject.transform.position);
        if (Vector2.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)) < radius)
        {
            mouseWithin = true;

            if (zoom.hotSpotMax < maxZoomClamp)
            zoom.hotSpotMax = maxZoomClamp;
        }
        else if (mouseWithin)
        {
            mouseWithin = false;
            zoom.hotSpotMax = 0;
        }
    }

}
