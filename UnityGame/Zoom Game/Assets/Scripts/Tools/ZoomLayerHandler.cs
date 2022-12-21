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

    private bool actionPerformedForZoomLevel0 = false;
    private bool actionPerformedForZoomLevel0b = false;
    private bool actionPerformedForZoomLevel1 = false;
    private bool actionPerformedForZoomLevel2 = false;
    private bool actionPerformedForZoomLevel3 = false;
    private bool actionPerformedForZoomLevel4 = false;

    public void CheckZoomLevel()
    {
        float zoomValue = zoom.currentZoomValue;


        if (zoomValue >= 1f && zoomValue < 2)
        {
            if (!actionPerformedForZoomLevel0)
            {
                actionPerformedForZoomLevel0 = true;
                NarratorHandler.Instance.PlayFromKeyWord("opening");
            }
            return;
        }

        if (zoomValue >= 4f && zoomValue < 5)
        {
            if (!actionPerformedForZoomLevel0b)
            {
                actionPerformedForZoomLevel0b = true;
                FindObjectOfType<TutorialHandler>().ExitZoom();
            }
            return;
        }


        if (zoomValue >= 9.58f && zoomValue < 12)
        {
            if (!actionPerformedForZoomLevel1)
            {
                actionPerformedForZoomLevel1 = true;
                FindObjectOfType<TutorialHandler>().DisplayPan();
                PanChange("ZoomLayer2 - Hallway");
                player.canOnlyZoomIn = false;
                player.canInput = true;
                player.canZoom = true;
                player.canPan = true;
                SetLayerFunctions("ZoomLayer2 - Hallway", true);
                InstansiateNewZoomLayer("ZoomLayer3 - Bedroom");
                DeleteZoomLayer("ZoomLayer0 - MainMenu");
                zoom.zoomMax = 10.8f;
                zoom.zoomMin = 9.58f;
                zoom.smoothZoom = 0.1f;
            }
            return;
        }



        else if (zoomValue >= 17.9f && zoomValue < 19)
        {
            if (!actionPerformedForZoomLevel2)
            {
                actionPerformedForZoomLevel2 = true;
                PanChange("ZoomLayer3 - Bedroom");
                NarratorHandler.Instance.PlayFromKeyWord("bedroom");
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
                SetLayerFunctions("ZoomLayer3 - Bedroom", false);
                player.inCutscene = true;

                zoom.zoomMax = 23f;
                zoom.zoomMin = 20.29018f;
            }
            return;

        }
        else if (zoomValue > 25.2f && zoomValue < 26)
        {
            if (!actionPerformedForZoomLevel4)
            {
                actionPerformedForZoomLevel4 = true;
                PanChange("ZoomLayer5 - Tunnel");
                SetLayerFunctions("ZoomLayer4 - CaveEntrance", false);
                //DeleteZoomLayer("ZoomLayer4 - CaveEntrance");

                zoom.zoomMax = 27f;
                zoom.zoomMin = 25f;
            }
            return;

        }
    }

    //Methods to call 

    public void InstansiateNewZoomLayer(string name)
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

