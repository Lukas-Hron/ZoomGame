using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomHandler : MonoBehaviour
{
    public bool isZoom = false; //Updates Scaling of all active layers when enabled
    Vector2 mousePos; // Mouse position in game coordinates
    [SerializeField] private float smoothZoom = 0.1f; //How smooth the zoom should be
    [SerializeField] private float zoomSpeed = 0.2f; //How far you zoom with each scroll
    public float zoomInMultiplier = 0.5f;
    public float zoomValue = -1; //Target ZoomLevel
    float currentZoomValue = -1;
    public GameObject[] ZoomLayers; //Current layers loaded in

    [SerializeField] public float tempZoomMin, tempZoomMax; //Clamp min and max
    [SerializeField] public float zoomMin, zoomMax; 
    void Start()
    {
        isZoom = true;
        zoomMax = 8;
        zoomMin = -5;

        SetZoomClamp(0, 0); //set starting clamp

        for (var i = 0; i < ZoomLayers.Length; i++) //Loop over every layer and align it correctly
        {
            float layerZoom = currentZoomValue - ZoomLayers[i].GetComponent<Layer>().size;
            layerZoom = Mathf.Exp(layerZoom);
            ZoomLayers[i].transform.localScale = new Vector3(layerZoom, layerZoom, -10);

            if (i > 0)
            {
                ZoomLayers[i].transform.position = ZoomLayers[i - 1].GetComponent<Layer>().nextLayerPos.position;
            }
        }

    }

    void Update()
    {
        
        if (Input.mouseScrollDelta != Vector2.zero && !Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Max grej
            //mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2));
            isZoom = true;

        }
        if (isZoom)
        {
            MoveToZoomLevel();
        }
    }

    void MoveToZoomLevel()
    {
        for (var i = 0; i < ZoomLayers.Length; i++)
        {
            float layerZoom = currentZoomValue - ZoomLayers[i].GetComponent<Layer>().size;
            layerZoom = Mathf.Exp(layerZoom);
            ScaleAround(ZoomLayers[i], new Vector3(mousePos.x, mousePos.y, 0), new Vector3(layerZoom, layerZoom, -10));

            if (i > 0)
            {
                ZoomLayers[i].transform.position = ZoomLayers[i - 1].GetComponent<Layer>().nextLayerPos.position;
            }
        }

        if (Input.mouseScrollDelta.y < 0) //Constrain Zooming in to hotspots only
            zoomValue = (Input.mouseScrollDelta.y * zoomSpeed) + zoomValue;
        else
            zoomValue = (Input.mouseScrollDelta.y * zoomSpeed * zoomInMultiplier) + zoomValue;

        if (Input.mouseScrollDelta.y != 0)
        zoomValue = Mathf.Clamp(zoomValue, tempZoomMin, tempZoomMax); //Clamp zoom value

        currentZoomValue = Mathf.SmoothStep(currentZoomValue, zoomValue, smoothZoom);
        if (Mathf.Abs(currentZoomValue - zoomValue) < 0.01)
        {
            isZoom = false;
        }

    }

    public void ScaleAround(GameObject target, Vector3 pivot, Vector3 newScale)
    {
        Vector3 A = target.transform.localPosition;
        Vector3 B = pivot;

        Vector3 C = A - B; // diff from object pivot to desired pivot/origin

        float RS = newScale.x / target.transform.localScale.x; // relataive scale factor

        // calc final position post-scale
        Vector3 FP = B + C * RS;

        // finally, actually perform the scale/translation
        target.transform.localScale = newScale;
        target.transform.localPosition = FP;
    }

    public void SetZoomClamp(float min, float max)
    {
        if (min != 0)
            tempZoomMin = min;
        if (max != 0)
            tempZoomMax = max;
        if (max == 0 && min == 0)
        {
            tempZoomMax = zoomMax;
            tempZoomMin = zoomMin;
        }

    }
}
