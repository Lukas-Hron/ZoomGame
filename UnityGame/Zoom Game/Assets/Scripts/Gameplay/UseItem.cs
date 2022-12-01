using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    Inventory inventory;
    Item key;
    private void Start()
    {
        //item = GameObject.Find("Key").GetComponent<Item>();
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        key = GameObject.Find("Key").GetComponent<Item>();
    }
    private void OnMouseDown()
    {
        if (gameObject.tag == "UsableItem")
            Debug.Log("Keyhole Clicked");
        if (inventory.itemList.Contains(key))
            Debug.Log("Item found");
            inventory.RemoveItem("key");
    }
}
