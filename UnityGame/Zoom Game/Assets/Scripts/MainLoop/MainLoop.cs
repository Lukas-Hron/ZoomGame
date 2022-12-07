using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoop : MonoBehaviour
{
    Player player;

    ZoomLayer[] zoomLayerArray;
    ZoomLayer currentZoomLayer;
    ZoomLayer nextZoomLayer;
    int zoomLayerCounter;

    CameraPan cameraPanner = new CameraPan();
    
    void Start()
    {
        player = new Player();
        zoomLayerArray = new ZoomLayer[5];
        zoomLayerCounter = 0;
        currentZoomLayer = zoomLayerArray[0];
        nextZoomLayer = zoomLayerArray[1];

        cameraPanner = new CameraPan();
        cameraPanner.initiate();

    }


    void Update()
    {
        player = cameraPanner.ZoomUpdate(player);
        player = currentZoomLayer.updateZoomLayer(player);
       
        if (currentZoomLayer.transissionForward())
        {
            if (zoomLayerCounter == (zoomLayerArray.Length - 1))                // REACHED END OF THE GAME
            {

            }
            else {                                                              // IF NOT MOVE TO THE NEXT ZOOMLAYER
                loadNewZoomLayers();
            }

        }
    }
    /// <summary>
    /// Loads new Zoomlayers to be viewed and disables the one that you are leaving
    /// </summary>
    private void loadNewZoomLayers()
    {
        zoomLayerCounter++;
        currentZoomLayer = zoomLayerArray[zoomLayerCounter];
        nextZoomLayer = zoomLayerArray[zoomLayerCounter + 1];
        nextZoomLayer.enableZoomLayer();
        zoomLayerArray[zoomLayerCounter - 1].disableZoomLayer();
    }
}
