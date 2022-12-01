using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Item : MonoBehaviour
{
    Collider2D _collider;
    Inventory inventory;
    [SerializeField] float inventorySize;

    private void Start()
    {
        inventory = UnityEngine.Object.FindObjectOfType<Inventory>();
        _collider = GetComponent<Collider2D>();
    }
    public void OnMouseDown()
    {
        inventory.AddItem(this,inventorySize);
        _collider.enabled = false;
    }
}
