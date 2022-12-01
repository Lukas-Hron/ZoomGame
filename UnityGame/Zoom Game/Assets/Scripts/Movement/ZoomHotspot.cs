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



        zoomMultipler = Mathf.InverseLerp(radius, 0, Vector2.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition))); //Max grej
        //zoomMultipler = Mathf.InverseLerp(radius, 0, Vector2.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2))));


        zoom.zoomInMultiplier = falloffCurve.Evaluate(zoomMultipler);

        Debug.Log("Radius " + radius + ". Current Zoom Multiplier " + zoomMultipler+".");
    }

    private void OnMouseExit()
    {
        zoom.SetZoomClamp(0, 0);
        zoomMultipler = 0;
        zoom.zoomInMultiplier = 0.5f;
        Debug.Log("Radius " + radius + ". Current Zoom Multiplier " + zoomMultipler + ". Cursor has exited");
    }

}
