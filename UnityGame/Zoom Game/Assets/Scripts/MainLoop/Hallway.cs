using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : ZoomLayer
{
    public GameObject background;
    public GameObject[] zoomLayerObjects;
    public (float, float) zoomingConstraints;
    public Transform nextLayerPos;


    public void disableZoomLayer()
    {
        foreach(GameObject gameObject in zoomLayerObjects)
        {
            gameObject.SetActive(false);
        }
        background.SetActive(false);
    }

    public void enableZoomLayer()
    {
        foreach (GameObject gameObject in zoomLayerObjects)
        {
            gameObject.SetActive(true);
        }
        background.SetActive(true);
    }

    public bool transissionForward()
    {
        throw new System.NotImplementedException();
    }

    public Player updateZoomLayer(Player player)
    {
        throw new System.NotImplementedException();
    }
}
