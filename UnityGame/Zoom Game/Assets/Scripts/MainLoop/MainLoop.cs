using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoop : MonoBehaviour
{
    Player player;

    // ALL ZOOMLAYERS = THE COMPLETE GAME
    ZoomLayer[] zoomLayerArray;
    ZoomLayer currentZoomLayer;
    ZoomLayer nextZoomLayer;
    int zoomLayerCounter;

    CameraPan cameraPanner = new CameraPan();
    
    void Start()
    {
        //1. Initiate player: Set state to main menu, set empty inventory
        //2. Load all Zoomlayers
        //3. Disable all Zoomlayers
        //4. Enable the 1st and 2nd Zoomlayer (main menu and transsision)
        //5. Initiate Camera.

        player = new Player();                                                  // 1

        zoomLayerArray = new ZoomLayer[5];                                      // 2
        zoomLayerCounter = 0;
        currentZoomLayer = zoomLayerArray[0];
        nextZoomLayer = zoomLayerArray[1];
                                                                                // 3      TASK_INCOMPLETE DISABLE ALL ZOOMLAYERS
                                                                                // 4      TASK_INCOMPLETE ENABLE ALL ZOOMLAYERS

        cameraPanner = new CameraPan();                                         // 5   
        cameraPanner.initiate();

    }

    void Update()
    {
        // 1. Update the camera (panning/zooming or both) - Camera can change player state ->Panning/zooming
        // 2. Update current ZoomLayer - Zoomlayer takes a player (inventory and state) and can modify it upon returning

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
