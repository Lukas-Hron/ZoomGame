using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Item : MonoBehaviour
{
    public Inventory inventory;

    public void OnMouseDown()
    {
        inventory.AddItem(this);
    }
}
