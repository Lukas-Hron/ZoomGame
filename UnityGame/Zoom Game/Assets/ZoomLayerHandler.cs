using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLayerHandler : MonoBehaviour
{
    ZoomHandler zoom;
    CameraPan pan;
    public List<GameObject> zoomLayerPrefab;
    private void Start()
    {
        zoom = GetComponent<ZoomHandler>();
        pan = Camera.main.GetComponent<CameraPan>();
        zoom.ZoomLayers.Add(Instantiate(zoomLayerPrefab.Find(x => x.name == "ZoomLayer0 - Test Variant"), transform.position + new Vector3(-0.5f, 0, 0), Quaternion.identity));
        PanChange("ZoomLayer0 - Test Variant");

    }

    private void Update()
    {


    }


    private bool actionPerformedForZoomLevel1 = false;
    private bool actionPerformedForZoomLevel2 = false;
    private bool actionPerformedForZoomLevel3 = false;

    public void CheckZoomLevel()
    {
        float zoomValue = zoom.zoomValue;



        if (zoomValue >= 0.9 && zoomValue < 2)
        {
            if (!actionPerformedForZoomLevel1)
            {
                actionPerformedForZoomLevel1 = true;

            }
            return;
        }



        else if (zoomValue >= 4 && zoomValue < 5)
        {
            if (!actionPerformedForZoomLevel2)
            {
                actionPerformedForZoomLevel2 = true;


            }
            return;
        }



        else if (zoomValue >= 0 && zoomValue < 0)
        {
            if (!actionPerformedForZoomLevel3)
            {
                actionPerformedForZoomLevel3 = true;

            }
            return;

        }
    }

    //Methods to call 

    void InstansiateNewZoomLayer(string name)
    {
        zoom.ZoomLayers.Add(Instantiate(zoomLayerPrefab.Find(x => x.name == name), zoom.ZoomLayers[zoom.ZoomLayers.Count - 1].GetComponent<Layer>().nextLayerPos.transform.position + new Vector3(-0.5f, 0, 0), Quaternion.identity));
        zoom.RealignZoomlayers();
    }

    void PanChange(string name)
    {
        pan.layer = zoom.ZoomLayers.Find(x => x.name == name + "(Clone)").transform;
        pan.UpdatePanConstraints();
    }

    void DeleteZoomLayer(string name)
    {
        GameObject layer = zoom.ZoomLayers.Find(x => x.name == name + "(Clone)");
        GameObject.Destroy(layer, 0.1f);
        zoom.ZoomLayers.Remove(layer);

    }
    public void SetLayerFunctions(string name, bool x)
    {
        Layer lay = zoom.ZoomLayers.Find(x => x.name == name + "(Clone)").GetComponent<Layer>();
        if (x)
        {
            lay.EnableLayerFunctions();
        }
        else if (!x)
        {
            lay.DisableLayerFunctions();
        }
    }

    public void SetZoomConstraints(float min, float max)
    {
        if (min != 0)
            zoom.zoomMin = min;
        if (max != 0)
            zoom.zoomMax = max;
    }

    public void SetPlayerState()
    {
        // :D
    }
}

