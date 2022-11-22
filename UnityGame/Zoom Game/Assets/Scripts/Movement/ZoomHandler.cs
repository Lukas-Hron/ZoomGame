using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ZoomHandler : MonoBehaviour
{
    public float ZoomValue = 0;
    public GameObject[] ZoomLayers;
    void Start()
    {
        
    }

    void Update()
    {
        foreach (GameObject layer in ZoomLayers)
        {
            
            layer.transform.localScale = Vector3.zero;
        }
    }

    void MoveToZoomLevel()
    {

    }
}
