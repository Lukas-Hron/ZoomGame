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
    bool mouseIn;


    // Start is called before the first frame update
    void Start()
    {
        zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    private void OnMouseEnter()
    {

    }

    private void FixedUpdate()
    {
        radius = Vector2.Distance(radiusPoint.position, gameObject.transform.position);
        if (Vector2.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)) < radius)
        {
            mouseIn = true;
            zoom.hotSpotMax = maxZoomClamp;
        }
        else if (mouseIn)
        {
            mouseIn = false;
            zoom.hotSpotMax = 0;
        }
    }

}
