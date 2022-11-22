using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ZoomHandler : MonoBehaviour
{
    Vector2 mousePos;
       [SerializeField] private float smoothZoom = 0.1f;
    public float zoomMultiplier = 0.2f;
    float currentZoomValue = 0;
    public float zoomValue = 0;
    public GameObject[] ZoomLayers;
    void Start()
    {
        foreach (GameObject layer in ZoomLayers)
        {
            float layerZoom = currentZoomValue - layer.GetComponent<Layer>().value;
            layerZoom = Mathf.Exp(layerZoom);
            layer.transform.localScale = new Vector3(layerZoom, layerZoom, -10);
        }

    }

    void Update()
    {
        if (Input.mouseScrollDelta != Vector2.zero)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        foreach (GameObject layer in ZoomLayers)
        {
            float layerZoom = currentZoomValue - layer.GetComponent<Layer>().value;
            layerZoom = Mathf.Exp(layerZoom);
            //layer.transform.localScale = new Vector3(layerZoom, layerZoom, -10);
            ScaleAround(layer, new Vector3(mousePos.x, mousePos.y, 0), new Vector3(layerZoom, layerZoom, -10));
        }

        zoomValue = (Input.mouseScrollDelta.y * zoomMultiplier) + zoomValue;
        currentZoomValue = Mathf.SmoothStep(currentZoomValue, zoomValue, smoothZoom);
    }

    void MoveToZoomLevel()
    {

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
}
