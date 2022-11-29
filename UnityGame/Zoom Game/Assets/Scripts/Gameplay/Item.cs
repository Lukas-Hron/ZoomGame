using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Item : MonoBehaviour
{
    Collider2D _collider;
    public Inventory inventory;

    private void Start()
    {
        _collider = GetComponent<Collider2D>();
    }
    public void OnMouseDown()
    {
        inventory.AddItem(this);
        _collider.enabled = false;
    }
}
