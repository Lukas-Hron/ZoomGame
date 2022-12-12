using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    Animator win;
    Inventory inventory;
    Item keyItem;
    GameObject key;
    private void Start()
    {
        //item = GameObject.Find("Key").GetComponent<Item>();
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();

        key = GameObject.Find("Key");
        keyItem = key.GetComponent<Item>();
        win = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        if (gameObject.tag == "UsableItem")
        {
            Debug.Log("Keyhole Clicked");
        }

        if (inventory.itemList.Contains(keyItem))
        {
            win.SetTrigger("win");
            Debug.Log("Item found");
            inventory.RemoveItem("Key");
            Destroy(key);

        }
    }
}
