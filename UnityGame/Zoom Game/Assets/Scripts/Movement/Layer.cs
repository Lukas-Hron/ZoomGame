using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour
{
    public List<GameObject> hotSpots;
    public List<GameObject> objectsWithColliders;
    public float size = 0;
    public Transform nextLayerPos;

    private void Start()
    {
        DisableLayerFunctions();
    }



    public void DisableLayerFunctions()
    {
        foreach (GameObject hotspot in hotSpots)
        {
            hotspot.SetActive(false);
        }

        foreach (GameObject obj in objectsWithColliders)
        {
            foreach (var col in obj.GetComponentsInChildren<Collider2D>())
            {
                    col.enabled = false;
            }
        }
    }

    public void EnableLayerFunctions()
    {
        foreach (GameObject hotspot in hotSpots)
        {
            hotspot.SetActive(true);
        }

        foreach (GameObject obj in objectsWithColliders)
        {
            foreach (var col in obj.GetComponentsInChildren<Collider2D>())
            {
                if (!col.isTrigger)
                    col.enabled = true;
            }
        }
    }
}


