using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomHandler : MonoBehaviour
{
    bool isZoom = false;
    Vector2 mousePos;
    [SerializeField] private float smoothZoom = 0.1f;
    [SerializeField] private float zoomMultiplier = 0.2f;
    public float zoomValue = 0;
    float currentZoomValue = 0;
    public GameObject[] ZoomLayers;
    void Start()
    {
        for (var i = 0; i < ZoomLayers.Length; i++)
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
        if (Input.mouseScrollDelta != Vector2.zero)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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

        zoomValue = (Input.mouseScrollDelta.y * zoomMultiplier) + zoomValue;
        currentZoomValue = Mathf.SmoothStep(currentZoomValue, zoomValue, smoothZoom);
        if (currentZoomValue == zoomValue)
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
}
