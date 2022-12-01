using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZoomHotspot : MonoBehaviour
{
    [SerializeField] private float minZoomClamp, maxZoomClamp;
    public Transform radiusPoint;
    public float radius;
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
        if (Vector2.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)) < Vector2.Distance(radiusPoint.position, gameObject.transform.position))
        {
            mouseIn = true;
            zoom.SetZoomClamp(minZoomClamp, maxZoomClamp);
            Debug.Log("Radius " + radius + ".");
        }
        else if (mouseIn)
        {
            mouseIn = false;
            zoom.SetZoomClamp(0, 0);
            Debug.Log("Radius " + radius + ". Cursor has exited");
        }
    }

}
