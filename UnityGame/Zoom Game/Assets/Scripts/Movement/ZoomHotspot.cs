using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZoomHotspot : MonoBehaviour
{
    [SerializeField] private float minZoomClamp, maxZoomClamp;
    public AnimationCurve falloffCurve;
    public Transform radiusPoint;
    public float radius;
    public float zoomMultipler;
    ZoomHandler zoom;


    // Start is called before the first frame update
    void Start()
    {
     zoom = Object.FindObjectOfType<ZoomHandler>();
    }

    private void OnMouseEnter()
    {
        zoom.SetZoomClamp(minZoomClamp, maxZoomClamp);
    }

    private void OnMouseOver()
    {

        radius = Vector2.Distance(radiusPoint.position, gameObject.transform.position);



        zoomMultipler = Mathf.InverseLerp(radius, 0 , Vector2.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)));


        zoom.zoomInMultiplier = falloffCurve.Evaluate(zoomMultipler);

        Debug.Log("Radius " + radius + ". Current Zoom Multiplier " + zoomMultipler+".");
    }

    private void OnMouseExit()
    {
        zoom.SetZoomClamp(3.6f, 5);
        zoomMultipler = 0;
        zoom.zoomInMultiplier = 0.5f;
        Debug.Log("Radius " + radius + ". Current Zoom Multiplier " + zoomMultipler + ". Cursor has exited");
    }

}