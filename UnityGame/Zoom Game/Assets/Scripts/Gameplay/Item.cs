using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Item : MonoBehaviour, IPointerClickHandler
{
    public Inventory inventory;

    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.AddItem(this);
    }
}
