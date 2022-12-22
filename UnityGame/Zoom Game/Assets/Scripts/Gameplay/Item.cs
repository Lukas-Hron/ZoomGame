using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Item : MonoBehaviour
{
    public AudioClip pickupSound;
    Player player;
    Collider2D _collider;
    Inventory inventory;
    [SerializeField] float inventorySize;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        inventory = UnityEngine.Object.FindObjectOfType<Inventory>();
        _collider = GetComponent<Collider2D>();
    }
    public void OnMouseDown()
    {
        if (player.canInteract) { 
        inventory.AddItem(this,inventorySize);
        _collider.enabled = false;
        player.canClick = false;
            AudioHandler.Instance.PlaySoundEffect(pickupSound);
        }
    }

        private void OnMouseEnter()
    {
        if (player.canInteract)
        {
            player.canClick = true;
        }
    }
        private void OnMouseExit()
    {
            player.canClick = false;
    }
}
