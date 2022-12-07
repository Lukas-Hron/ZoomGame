using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : ZoomLayer
{
    public GameObject background;
    public ZoomLayerObject[] zoomLayerObjects;
    public (float, float) zoomingConstraints;
    public Transform nextLayerPos;


    public void disableZoomLayer()
    {
        foreach(ZoomLayerObject gameObject in zoomLayerObjects)
        {
            gameObject.getGameObject().SetActive(false);
        }
        background.SetActive(false);
    }

    public void enableZoomLayer()
    {
        
        foreach (ZoomLayerObject gameObject in zoomLayerObjects)
        {
            gameObject.getGameObject().SetActive(true);
        }
        background.SetActive(true);
    }

    public void loadZoomLayer()
    {
        zoomLayerObjects = new ZoomLayerObject[1];
        zoomLayerObjects[0] = new ZoomLayerObject(GameObject.Find("key"));

    }

    public bool transissionForward()
    {
        return false;
    }

    public Player updateZoomLayer(Player player)
    {
        player.getInventory();
        if (keyHasbeenUsed)
        {
            
        }
    }
    
}
