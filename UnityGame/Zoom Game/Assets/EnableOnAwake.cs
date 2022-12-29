using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnAwake : MonoBehaviour
{
    [SerializeField] bool InstanciateZoomLayer;
    [SerializeField] List<GameObject> gameObjects;
    [SerializeField] string layerName;
    // Start is called before the first frame update
    private void Start()
    {
        foreach (GameObject obj in gameObjects)
        {
            obj.SetActive(true);
        }
        if (InstanciateZoomLayer)
        {
            FindObjectOfType<ZoomLayerHandler>().InstansiateNewZoomLayer(layerName);
        }
    }
}
