using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLayerHandler : MonoBehaviour
{
    Player player;
    ZoomHandler zoom;
    CameraPan pan;
    public List<GameObject> zoomLayerPrefab;
    private void Start()
    {
        player = FindObjectOfType<Player>();
        zoom = GetComponent<ZoomHandler>();
        pan = Camera.main.GetComponent<CameraPan>();
        zoom.ZoomLayers.Add(Instantiate(zoomLayerPrefab.Find(x => x.name == "ZoomLayer0 - MainMenu"), transform.position, Quaternion.identity));
        PanChange("ZoomLayer0 - MainMenu");
        InstansiateNewZoomLayer("ZoomLayer2 - Hallway");

    }

    private void Update()
    {


    }


    private bool actionPerformedForZoomLevel1 = false;
    private bool actionPerformedForZoomLevel2 = false;
    private bool actionPerformedForZoomLevel3 = false;

    public void CheckZoomLevel()
    {
        float zoomValue = zoom.currentZoomValue;



        if (zoomValue >= 9.58f && zoomValue < 12)
        {
            if (!actionPerformedForZoomLevel1)
            {
                PanChange("ZoomLayer2 - Hallway");
                player.canOnlyZoomIn = false;
                player.canInput = true;
                player.canZoom = true;
                player.canPan = true;
                actionPerformedForZoomLevel1 = true;
                SetLayerFunctions("ZoomLayer2 - Hallway", true);
                InstansiateNewZoomLayer("ZoomLayer3 - Bedroom");
                DeleteZoomLayer("ZoomLayer0 - MainMenu");
                zoom.zoomMax = 10.8f;
                zoom.zoomMin = 9.58f;
            }
            return;
        }



        else if (zoomValue >= 17.9f && zoomValue < 19)
        {
            if (!actionPerformedForZoomLevel2)
            {
                actionPerformedForZoomLevel2 = true;
                PanChange("ZoomLayer3 - Bedroom");
                zoom.zoomMax = 19.4f;
                zoom.zoomMin = 17.7f;
                SetLayerFunctions("ZoomLayer2 - Hallway", false);
  
                DeleteZoomLayer("ZoomLayer2 - Hallway");
            }
            return;
        }



        else if (zoomValue >= 20 && zoomValue < 21)
        {
            if (!actionPerformedForZoomLevel3)
            {
                actionPerformedForZoomLevel3 = true;
                InstansiateNewZoomLayer("ZoomLayer4 - CaveEntrance");
                PanChange("ZoomLayer4 - CaveEntrance");
                SetLayerFunctions("ZoomLayer3 - Bedroom", false);

                zoom.zoomMax = 23f;
                zoom.zoomMin = 20.29018f;
            }
            return;

        }
    }

    //Methods to call 

    void InstansiateNewZoomLayer(string name)
    {
        zoom.ZoomLayers.Add(Instantiate(zoomLayerPrefab.Find(x => x.name == name), zoom.ZoomLayers[zoom.ZoomLayers.Count - 1].GetComponent<Layer>().nextLayerPos.transform.position, Quaternion.identity));
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

